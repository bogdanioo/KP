using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using KP.Classes;

namespace KP
{
    public partial class Detal : Form
    {

        int index, why;
        public Detal(int ind, int list)
        {
            index = ind;
            why = list;
            InitializeComponent();
            update();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && Regex.IsMatch(textBox1.Text, @"^\d+$"))
            {
                try
                {
                    OnlineAuction.Auctions[index].AddBid(OnlineAuction.Users[OnlineAuction.userId].Id, Convert.ToInt16(textBox1.Text), DateTime.Now);
                    label1.Text = "Баланс: " + OnlineAuction.Users[OnlineAuction.userId].balance;

                    string a = OnlineAuction.Auctions[index].ViewBids();
                    textBox3.Text = a;
                    update();
                    OnlineAuction.SaveToAuctions();
                    OnlineAuction.SaveToUsers();
                    OnlineAuction.SaveToUsers();


                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);


                }
            }
            else MessageBox.Show("Введіть тільки цифри!");








        }
        public void update()
        {

            if (why == 1)
            {
                label2.Text = Convert.ToString(OnlineAuction.Auctions[index].name);
                textBox2.Text = OnlineAuction.Auctions[index].description;
                string a = OnlineAuction.Auctions[index].ViewBids();
                textBox3.Text = a;
                pictureBox1.Image = OnlineAuction.Auctions[index].image;
                if (OnlineAuction.userType == "User")
                {

                    label1.Text = "Баланс: " + OnlineAuction.Users[OnlineAuction.userId].balance;

                    if (textBox1.Visible == false && button1.Visible == false)
                    {
                        textBox1.Visible = true;
                        button1.Visible = true;
                    }

                    timer1.Start();


                }
                else
                {
                    textBox1.Visible = false;
                    button1.Visible = false;

                    label3.Text = "Початок: " + OnlineAuction.Auctions[index].startAuction + "\n Кінець: " + OnlineAuction.Auctions[index].endAuction;

                }



            }
            else
            {
                textBox1.Visible = false;
                button1.Visible = false;
                pictureBox1.Image = OnlineAuction.PastAuctions[index].image;
                textBox2.Text = OnlineAuction.PastAuctions[index].description;
                string a = OnlineAuction.PastAuctions[index].ViewBids();
                label3.Text = "Початок: " + OnlineAuction.PastAuctions[index].startAuction + "\n Кінець: " + OnlineAuction.PastAuctions[index].endAuction;
                textBox3.Text = a;




            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (OnlineAuction.Auctions[index].startAuction < DateTime.Now)
            {
                button1.Visible = true;
                textBox1.Visible = true;

                TimeSpan remainingTime = OnlineAuction.Auctions[index].endAuction - DateTime.Now;
                string remainingTimeString = "До кінця аукціону залишилося: \n";

                if (remainingTime.TotalHours >= 1)
                {
                    int hours = (int)remainingTime.TotalHours;
                    string hoursForm = GetNounForm(hours, "година", "години", "годин");
                    remainingTimeString += $"{hours} {hoursForm} ";
                }

                if (remainingTime.TotalMinutes >= 1)
                {
                    int minutes = (int)remainingTime.TotalMinutes % 60;
                    string minutesForm = GetNounForm(minutes, "хвилина", "хвилини", "хвилин");
                    remainingTimeString += $"{minutes} {minutesForm} ";
                }

                if (remainingTime.TotalSeconds >= 1)
                {
                    int seconds = (int)remainingTime.TotalSeconds % 60;
                    string secondsForm = GetNounForm(seconds, "секунда", "секунди", "секунд");
                    remainingTimeString += $"{seconds} {secondsForm}";
                }

                label3.Text = remainingTimeString;

                if (remainingTime.TotalMinutes < 0)
                {

                    timer1.Stop();

                    textBox1.Visible = false;
                    button1.Visible = false;
                    label3.Text = "";
                    MessageBox.Show(OnlineAuction.Auctions[index].CalculateWinner());
                    if (OnlineAuction.Auctions[index].winner != -1 && OnlineAuction.Auctions[index].winner == OnlineAuction.Users[OnlineAuction.userId].Id && OnlineAuction.userType == "User")
                    {
                        OnlineAuction.Users[OnlineAuction.userId].Notification[OnlineAuction.Users[OnlineAuction.userId].Notification.Count-1].isNotificationRead = true;

                    }
                    OnlineAuction.PastAuctions.Add(OnlineAuction.Auctions[index]);
                    OnlineAuction.Auctions.RemoveAt(index);
                    OnlineAuction.SaveToAuctions();
                    OnlineAuction.SaveToPastAuctions();
                    OnlineAuction.SaveToUsers();



                }

            }
            else
            {

                label3.Text = "Аукціон ще не почався!";
                textBox1.Visible = false;
                button1.Visible = false;


            }
            timer1.Interval = 1000;

        }

        private void Detal_FormClosing(object sender, FormClosingEventArgs e)
        {

            timer1.Stop();

        }
        private string GetNounForm(int number, string form1, string form2, string form5)
        {
            if (number % 10 == 1 && number % 100 != 11)
            {
                return form1;
            }
            else if ((number % 10 >= 2 && number % 10 <= 4) && (number % 100 < 10 || number % 100 >= 20))
            {
                return form2;
            }
            else
            {
                return form5;
            }
        }

    }
}
