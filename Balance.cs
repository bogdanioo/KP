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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KP
{
    public partial class Balance : Form
    {

        public Balance()
        {
            InitializeComponent();
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BorderStyle == BorderStyle.None && pictureBox2.BorderStyle == BorderStyle.None && pictureBox3.BorderStyle == BorderStyle.None)
            {
                MessageBox.Show("Оберіть платіжну систему!");
            }
            else
            {
                bool result = OnlineAuction.Users[OnlineAuction.userId].RechargeBalance(Convert.ToInt32(textBox1.Text));
                if (result == true)
                {
                    MessageBox.Show("Баланс поповнено!");
                    OnlineAuction.SaveToUsers();
                    update();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Некоректна сума поповнення!");
                    textBox1.Text = "";

                }
            }

        }
        void update()
        {
            label1.Text = "Баланс - " + Convert.ToString(OnlineAuction.Users[OnlineAuction.userId].balance);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
        }
    }
}
