using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KP.Classes;

namespace KP
{
    public partial class Registr : Form
    {


        int type = 0;

        public Registr(int t)
        {
            type = t;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (type == 0)
            {

                try
                {
                    AuthorizedUser user = new AuthorizedUser();
                    user.AddUser(textBox1.Text, textBox2.Text, textBox3.Text);
                    OnlineAuction.Users.Add(user);
                    MessageBox.Show("Регістрація завершена!");
                    OnlineAuction.SaveToUsers();
                    this.Close();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);

                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);


                }


            }
            if (type == 2)
            {
                bool aut = OnlineAuction.Authorized(textBox1.Text, textBox2.Text);
                if (aut)
                {
                    MessageBox.Show("Вхід виконан!");
                    OnlineAuction.SaveToState();
                    Close();
                }
                else
                {
                    MessageBox.Show("Введені некоректні дані!");
                }

            }


            if (type == 3)
            {
                int index = OnlineAuction.userId;

                if (OnlineAuction.userType == "User")
                {

                    try
                    {

                        OnlineAuction.Users[index].ChangeAccountData(textBox1.Text, textBox2.Text);
                        MessageBox.Show("Данні успішно змінені");
                        OnlineAuction.SaveToUsers();
                        Close();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message);


                    }

                }
                else
                {
                    try
                    {

                        OnlineAuction.Admins[index].ChangeAccountData(textBox1.Text, textBox2.Text);
                        MessageBox.Show("Данні успішно змінені");
                        OnlineAuction.SaveToAdmins();
                        Close();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message);


                    }
                }


            }



        }

        private void Registr_Load(object sender, EventArgs e)
        {
            if (type == 2)
            {
                label1.Text = "Авторизація";
                label4.Visible = false;
                textBox3.Visible = false;
                button1.Location = new Point(94, 177);
                Size = new Size(315, 270);
                button1.Text = "Ввійти";


            }
            if (type == 3)
            {
                label1.Text = "Зміна даних";
                label4.Visible = false;
                textBox3.Visible = false;
                button1.Location = new Point(94, 177);
                Size = new Size(315, 270);
                button1.Text = "Зберегти";


            }
        }
    }
}
