using System;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using KP.Classes;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace KP
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            OnlineAuction.ReadToAdmins();
            OnlineAuction.ReadToAuctions();
            OnlineAuction.ReadToPastAuctions();
            OnlineAuction.ReadToUsers();
            OnlineAuction.ReadToState();
            адмініструванняToolStripMenuItem.Enabled = false;
            профільToolStripMenuItem.Enabled = false;

            toolStripComboBox1.SelectedIndex = 0;
            RefreshAll();

            CheckNotification();
            timer1.Start();

        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form1 = new Registr(2);
            Form1.ShowDialog();
            RefreshAll();
            CheckNotification();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var Form2 = new Registr(0);
            Form2.ShowDialog();
            RefreshAll();

        }
        private void RefreshAll()
        {

            if (OnlineAuction.Auctions.Count > 0)
            {
                dataGridView1.Visible = true;

                string selectedItem = toolStripComboBox1.SelectedItem.ToString();
                var Auctions = OnlineAuction.Auctions;

                if (selectedItem != "Все")
                {
                    onlineAuctionSystemBindingSource.DataSource = Auctions.Where(a => a.ItemType == selectedItem).ToList();
                }
                else
                {
                    onlineAuctionSystemBindingSource.DataSource = Auctions;
                }
                onlineAuctionSystemBindingSource.ResetBindings(false);
            }
            else
            {
                dataGridView1.Visible = false;
                onlineAuctionSystemBindingSource.Clear();

            }



            UpdateControls();





        }
        private void UpdateControls()
        {

            switch (OnlineAuction.userType)
            {
                case "Admin":
                    UpdateControlsForAdmin();
                    break;
                case "User":
                    UpdateControlsForUser();
                    break;
                default:
                    UpdateControlsForGuest();
                    break;
            }
        }
        private void UpdateControlsForAdmin()
        {

            адмініструванняToolStripMenuItem.Enabled = true;
            профільToolStripMenuItem.Enabled = true;
            поповненняБалансуToolStripMenuItem.Enabled = false;
            label1.Text = "Адміністратор " + OnlineAuction.Admins[OnlineAuction.userId].username;
            входToolStripMenuItem.Enabled = false;
            dataGridView1.Columns["deleteButtonColumn"].Visible = true;
            dataGridView1.Columns["DetalCheck"].Visible = true;
            змінитиДаніToolStripMenuItem.Enabled = true;
            повідомленняToolStripMenuItem.Enabled = false;
            профільToolStripMenuItem.ForeColor = Color.Black;
        }

        private void UpdateControlsForUser()
        {

            профільToolStripMenuItem.Enabled = true;
            входToolStripMenuItem.Enabled = false;
            змінитиДаніToolStripMenuItem.Enabled = true;
            поповненняБалансуToolStripMenuItem.Enabled = true;
            label1.Text = $"{OnlineAuction.Users[OnlineAuction.userId].username} | Баланс: {OnlineAuction.Users[OnlineAuction.userId].balance}";
            dataGridView1.Columns["deleteButtonColumn"].Visible = false;
            dataGridView1.Columns["DetalCheck"].Visible = true;
            повідомленняToolStripMenuItem.Enabled = true;
        }
        private void UpdateControlsForGuest()
        {

            адмініструванняToolStripMenuItem.Enabled = false;
            профільToolStripMenuItem.Enabled = false;
            поповненняБалансуToolStripMenuItem.Enabled = false;
            входToolStripMenuItem.Enabled = true;
            змінитиДаніToolStripMenuItem.Enabled = false;
            label1.Text = "Гість";
            dataGridView1.Columns["deleteButtonColumn"].Visible = false;
            dataGridView1.Columns["DetalCheck"].Visible = true;
        }
        public void CheckNotification()
        {
            if (OnlineAuction.userType == "User")
            {
                if (OnlineAuction.Users[OnlineAuction.userId].Notification.Any(n => !n.isNotificationRead))
                {
                    профільToolStripMenuItem.ForeColor = Color.Red;
                    повідомленняToolStripMenuItem.ForeColor = Color.Red;

                    notifyIcon1.ShowBalloonTip(200);



                }
                else
                {
                    профільToolStripMenuItem.ForeColor = Color.Black;
                    повідомленняToolStripMenuItem.ForeColor = Color.Black;
                }
            }
        }


        private void додатиЛотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new AddLot();
            Form.ShowDialog();
            RefreshAll();

        }

        private void змінитиДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var Form2 = new Registr(3);
            Form2.ShowDialog();

            RefreshAll();

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OnlineAuction.userType = "";
            RefreshAll();
            OnlineAuction.SaveToState();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (OnlineAuction.userType == "User")
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "DetalCheck")
                {
                    timer1.Stop();
                    OnlineAuctionSystem auction = (OnlineAuctionSystem)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                    int index = OnlineAuction.Auctions.FindIndex(u => u == auction);

                    var Form = new Detal(index, 1);
                    Form.ShowDialog();

                    
                    RefreshAll();


                    timer1.Start();

                }
            }

            else
            {
                bool dell = false;
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "deleteButtonColumn")
                {
                    OnlineAuctionSystem auction = (OnlineAuctionSystem)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                    DialogResult result = MessageBox.Show("Ви впевнені?", "Підтвердіть видалення аукціону", MessageBoxButtons.YesNo);


                    if (result == DialogResult.Yes)
                    {

                        dell = OnlineAuction.Admins[OnlineAuction.userId].RemoveAuction(auction);
                        if (dell == true)
                        {
                            OnlineAuction.SaveToAuctions();

                            RefreshAll();

                        }
                        else { MessageBox.Show("Видалення неможливе, аукціон вже почався!"); }

                    }




                }
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "DetalCheck")
                {

                    OnlineAuctionSystem auction = (OnlineAuctionSystem)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                    int index = OnlineAuction.Auctions.FindIndex(u => u == auction);

                    var Form = new Detal(index, 1);
                    Form.ShowDialog();
                    RefreshAll();
                }


            }

        }

        private void поповненняБалансуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new Balance();
            Form.ShowDialog();
            RefreshAll();
        }

        private void переглянутиІсторіюToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (OnlineAuction.userType == "User")
            {

                if (OnlineAuction.Users[OnlineAuction.userId].BiddingHistory.Count() != 0)
                {
                    timer1.Stop();


                    var Form = new BiddingHistoryForm();
                    Form.ShowDialog();
                    RefreshAll();
                    timer1.Start();


                }
                else MessageBox.Show("Ви не робили ставок");


            }
            else
            {
                if (OnlineAuction.Admins[OnlineAuction.userId].actions.Count() != 0)
                {


                   
                    var Form = new AdminsActionsForm();
                    Form.ShowDialog();

                }
                else MessageBox.Show("Ви ще нічого не робили");

            }
            


        }

        private void минуліАукціониToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (OnlineAuction.PastAuctions.Count > 0)
            {
                var Form = new PastAuctForm();
                Form.ShowDialog();

            }
            else MessageBox.Show("Завершених аукціонів немає");

            RefreshAll();

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            RefreshAll();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (OnlineAuction.Auctions.Count > 0)
            {
                for (int i = 0; i < OnlineAuction.Auctions.Count; i++)
                {
                    var auction = OnlineAuction.Auctions[i];
                    if (auction.endAuction < DateTime.Now)
                    {

                        auction.CalculateWinner();
                        
                        if (OnlineAuction.userType == "User" && auction.winner == OnlineAuction.Users[OnlineAuction.userId].Id)
                        {
                            CheckNotification();
                           
                        }

                        OnlineAuction.PastAuctions.Add(auction);
                        OnlineAuction.Auctions.Remove(auction);
                        OnlineAuction.SaveToAuctions();
                        OnlineAuction.SaveToPastAuctions();
                        OnlineAuction.SaveToUsers();
                        RefreshAll();







                    }
                }
            }
        }

        private void повідомленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnlineAuction.Users[OnlineAuction.userId].Notification.Count > 0)
            {
                timer1.Stop();
                var Form = new NotificationForm();
                Form.ShowDialog();
                RefreshAll();
                CheckNotification();
                OnlineAuction.SaveToUsers();
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Повідомлення відсутні!");
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
            
        }
    }
}
