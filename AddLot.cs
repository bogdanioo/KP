using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KP.Classes;

namespace KP
{
    public partial class AddLot : Form
    {

        string im = string.Empty;
        public AddLot()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            openFileDialog1.Filter = "Файлы изображений|*.bmp;*.jpg;*.jpeg;*.png";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {


                    im = (openFileDialog1.FileName);
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                OnlineAuction.Admins[OnlineAuction.userId].AddAuction(textBox1.Text, textBox6.Text, im, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox1.Text);
                OnlineAuction.SaveToAuctions();
                OnlineAuction.SaveToAdmins();
                MessageBox.Show("Аукціон успішно доданий!");

                this.Close();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
    }
}
