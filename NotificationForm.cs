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
    public partial class NotificationForm : Form
    {

        public NotificationForm()
        {
            InitializeComponent();
            bindingSource1.DataSource = OnlineAuction.Users[OnlineAuction.userId].Notification;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                int d = 1;
                AuthorizedUser.AuctionNotification auction = (AuthorizedUser.AuctionNotification)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var auctionId = auction.IdAuction;
                int index = OnlineAuction.Auctions.FindIndex(u => u.Id == auctionId);
                if (index == -1)
                {
                    index = OnlineAuction.PastAuctions.FindIndex(u => u.Id == auctionId);
                    d = 2;
                }
                var Form = new Detal(index, d);
                Form.ShowDialog();
                bindingSource1.ResetBindings(false);

            }
        }

        private void NotificationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < OnlineAuction.Users[OnlineAuction.userId].Notification.Count; i++)
            {
                OnlineAuction.Users[OnlineAuction.userId].Notification[i].isNotificationRead = true;
            }
        }
    }
}
