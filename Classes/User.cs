using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KP.Classes
{
    public abstract class User : IUserable
    {

        private string Username;
        private string Password;




        public string username
        {
            get
            {
                return Username;
            }
            set
            {
                Username = value;
            }
        }
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }



       


        public void ChangeAccountData(string newLogin, string newPass)
        {

            bool userExists = false;
            if (OnlineAuction.Users != null)
            {
                userExists = OnlineAuction.Users.Where(u => u.username == newLogin).Any();
                if (userExists == false)
                {
                    userExists = OnlineAuction.Admins.Where(u => u.username == newLogin).Any();
                }
            }
            if (string.IsNullOrEmpty(newLogin) || newLogin.Length < 4)
            {

                throw new ArgumentException("Логін повинен містити більше 3х символів!");


            }

            else
            {
                if (userExists)
                {
                    throw new InvalidOperationException("Користувач з таким логіном вже існує!");
                }
                else
                {

                }
            }
            if (string.IsNullOrEmpty(newPass))
            {

                throw new ArgumentException("Введіть пароль!");


            }
            else
            {
                Password = newPass;
                Username = newLogin;

            }
          
        }
      
        public abstract class Actions
        {
            public DateTime Time { get; set; }
            public string Name { get; set; }
            
            
          
            public Guid IdAuction { get; set; }
            public Actions(DateTime time, Guid auction,string name)
            {
                Time = time;
                this.IdAuction = auction;
                this.Name = name;
            }
        }



    }
}
