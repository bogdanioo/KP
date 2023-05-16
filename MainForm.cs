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
            �������������ToolStripMenuItem.Enabled = false;
            �������ToolStripMenuItem.Enabled = false;

            toolStripComboBox1.SelectedIndex = 0;
            RefreshAll();

            CheckNotification();
            timer1.Start();

        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form1 = new Registr(2);
            Form1.ShowDialog();
            RefreshAll();
            CheckNotification();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
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

                if (selectedItem != "���")
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

            �������������ToolStripMenuItem.Enabled = true;
            �������ToolStripMenuItem.Enabled = true;
            �����������������ToolStripMenuItem.Enabled = false;
            label1.Text = "����������� " + OnlineAuction.Admins[OnlineAuction.userId].username;
            ����ToolStripMenuItem.Enabled = false;
            dataGridView1.Columns["deleteButtonColumn"].Visible = true;
            dataGridView1.Columns["DetalCheck"].Visible = true;
            ���������ToolStripMenuItem.Enabled = true;
            �����������ToolStripMenuItem.Enabled = false;
            �������ToolStripMenuItem.ForeColor = Color.Black;
        }

        private void UpdateControlsForUser()
        {

            �������ToolStripMenuItem.Enabled = true;
            ����ToolStripMenuItem.Enabled = false;
            ���������ToolStripMenuItem.Enabled = true;
            �����������������ToolStripMenuItem.Enabled = true;
            label1.Text = $"{OnlineAuction.Users[OnlineAuction.userId].username} | ������: {OnlineAuction.Users[OnlineAuction.userId].balance}";
            dataGridView1.Columns["deleteButtonColumn"].Visible = false;
            dataGridView1.Columns["DetalCheck"].Visible = true;
            �����������ToolStripMenuItem.Enabled = true;
        }
        private void UpdateControlsForGuest()
        {

            �������������ToolStripMenuItem.Enabled = false;
            �������ToolStripMenuItem.Enabled = false;
            �����������������ToolStripMenuItem.Enabled = false;
            ����ToolStripMenuItem.Enabled = true;
            ���������ToolStripMenuItem.Enabled = false;
            label1.Text = "ó���";
            dataGridView1.Columns["deleteButtonColumn"].Visible = false;
            dataGridView1.Columns["DetalCheck"].Visible = true;
        }
        public void CheckNotification()
        {
            if (OnlineAuction.userType == "User")
            {
                if (OnlineAuction.Users[OnlineAuction.userId].Notification.Any(n => !n.isNotificationRead))
                {
                    �������ToolStripMenuItem.ForeColor = Color.Red;
                    �����������ToolStripMenuItem.ForeColor = Color.Red;

                    notifyIcon1.ShowBalloonTip(200);



                }
                else
                {
                    �������ToolStripMenuItem.ForeColor = Color.Black;
                    �����������ToolStripMenuItem.ForeColor = Color.Black;
                }
            }
        }


        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new AddLot();
            Form.ShowDialog();
            RefreshAll();

        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var Form2 = new Registr(3);
            Form2.ShowDialog();

            RefreshAll();

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
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

                    DialogResult result = MessageBox.Show("�� �������?", "ϳ�������� ��������� ��������", MessageBoxButtons.YesNo);


                    if (result == DialogResult.Yes)
                    {

                        dell = OnlineAuction.Admins[OnlineAuction.userId].RemoveAuction(auction);
                        if (dell == true)
                        {
                            OnlineAuction.SaveToAuctions();

                            RefreshAll();

                        }
                        else { MessageBox.Show("��������� ���������, ������� ��� �������!"); }

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

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new Balance();
            Form.ShowDialog();
            RefreshAll();
        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
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
                else MessageBox.Show("�� �� ������ ������");


            }
            else
            {
                if (OnlineAuction.Admins[OnlineAuction.userId].actions.Count() != 0)
                {


                   
                    var Form = new AdminsActionsForm();
                    Form.ShowDialog();

                }
                else MessageBox.Show("�� �� ����� �� ������");

            }
            


        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (OnlineAuction.PastAuctions.Count > 0)
            {
                var Form = new PastAuctForm();
                Form.ShowDialog();

            }
            else MessageBox.Show("���������� �������� ����");

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

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show("����������� ������!");
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
            
        }
    }
}
