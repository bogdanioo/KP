using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KP.Classes;

namespace KP
{
    public partial class PastAuctForm : Form
    {

        public PastAuctForm()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;

            dataGridView1.AutoGenerateColumns = false;



        }

        private void PastAuctForm_Load(object sender, EventArgs e)
        {
            if (OnlineAuction.userType != "Admin")
            {
                mailWinnerDataGridViewTextBoxColumn.Visible = false;
            }
            onlineAuctionBindingSource.DataSource = OnlineAuction.PastAuctions;
            dataGridView1.DataSource = onlineAuctionBindingSource;

            onlineAuctionBindingSource.ResetBindings(false);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                int d = 1;
                OnlineAuctionSystem auction = (OnlineAuctionSystem)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var auctionId = auction;
                int index = OnlineAuction.Auctions.FindIndex(u => u == auctionId);
                if (index == -1)
                {
                    index = OnlineAuction.PastAuctions.FindIndex(u => u == auctionId);
                    d = 2;
                }
                var Form = new Detal(index, d);
                Form.ShowDialog();
                onlineAuctionBindingSource.ResetBindings(false);

            }
        }





        private void оновитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedItem = toolStripComboBox1.SelectedItem.ToString();
            var Auctions = OnlineAuction.PastAuctions;

            if (selectedItem != "Все")
            {
                onlineAuctionBindingSource.DataSource = Auctions.Where(a => a.ItemType == selectedItem).ToList();

            }
            else { onlineAuctionBindingSource.DataSource = Auctions; }
            onlineAuctionBindingSource.ResetBindings(false);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = toolStripComboBox1.SelectedItem.ToString();
            var Auctions = OnlineAuction.PastAuctions;

            if (selectedItem != "Все")
            {

                onlineAuctionBindingSource.DataSource = Auctions.Where(a => a.ItemType == selectedItem).ToList();

            }
            else { onlineAuctionBindingSource.DataSource = Auctions; }
            onlineAuctionBindingSource.ResetBindings(false);
        }
    }
}

