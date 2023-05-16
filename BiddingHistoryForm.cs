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
    public partial class BiddingHistoryForm : Form
    {

        public BiddingHistoryForm()
        {
            InitializeComponent();
            bidBindingSource.DataSource = OnlineAuction.Users[OnlineAuction.userId].BiddingHistory;
            bidBindingSource.ResetBindings(false);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                int d = 1;
                AuthorizedUser.Actions auction = (AuthorizedUser.Actions)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var auctionId = auction.IdAuction;
                int index = OnlineAuction.Auctions.FindIndex(u => u.Id == auctionId);
                if (index == -1)
                {
                    index = OnlineAuction.PastAuctions.FindIndex(u => u.Id == auctionId);
                    d = 2;
                }
                var Form = new Detal(index, d);
                Form.ShowDialog();
                bidBindingSource.ResetBindings(false);

            }

        }

    }
}
