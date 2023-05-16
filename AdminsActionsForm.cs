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
    public partial class AdminsActionsForm : Form
    {

        public AdminsActionsForm()
        {
            InitializeComponent();
            actionsAdmBindingSource.DataSource = OnlineAuction.Admins[OnlineAuction.userId].actions;  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                int d = 0;
                Administrator.Actions auction = (Administrator.Actions)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var auctionId = auction.IdAuction;
                int index = OnlineAuction.Auctions.FindIndex(u => u.Id == auctionId);
                if (index == -1)
                {
                    index = OnlineAuction.PastAuctions.FindIndex(u => u.Id == auctionId);
                    if (index == -1)
                    {
                        MessageBox.Show("Інформацію про видалений аукціон неможливо подивитись!");
                    }
                    else
                    {
                        d = 2;
                    }
                }
                else
                {
                    d = 1;
                }

                if (d != 0)
                {
                    var Form = new Detal(index, d);
                    Form.ShowDialog();
                }




            }
        }
    }
}
