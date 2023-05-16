using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KP.Classes
{
    public class AuthorizedUser : User, IUserManager
    {
        private static int Counter =0;

        public int Id { get; set; }

        private int Balance;
        private string Mail;

       
        public List<Actions> BiddingHistory = new List<Actions>();
        public List<AuctionNotification> Notification = new List<AuctionNotification>();
        public AuthorizedUser()
        {
            Id = ++Counter;
        }
        public int balance
        {
            get { return Balance; }
            set { Balance = value; }
        }
        public string mail
        {
            get { return Mail; }
            set { Mail = value; }

        }
        public void AddUser(string newLogin, string newPass, string newMail)
        {

            bool userExists = false;

            if (string.IsNullOrEmpty(newLogin) || newLogin.Length < 4)
            {
                
                throw new ArgumentException("Логін повинен містити більше 3х символів");
            }
            if (string.IsNullOrEmpty(newPass))
            {
                throw new ArgumentException("Заповніть всі поля!");
                
            }
            if (!newMail.Contains("@"))
            {
                throw new ArgumentException("Невірна пошта");
                
            }
            else
            {
                userExists = OnlineAuction.Users.Where(u => u.username == newLogin).Any();
                if ((OnlineAuction.Users.Where(u => u.username == newLogin).Any())==true || (userExists = OnlineAuction.Admins.Where(u => u.username == newLogin).Any())==true)
                {
                    throw new InvalidOperationException("Користувач з таким логіном вже існує");
                }
                else
                {
                   
                        username = newLogin;
                        password = newPass;
                        Mail = newMail;
                        Balance = 0;
                    



                }
            }

           

        }


        public bool RechargeBalance(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            
            return false;
        }


        public void AddActions( Guid idAuction, string name, int amount)
        {

            Actions b = new Actions(DateTime.Now, idAuction, name, amount);           
            BiddingHistory.Add(b);
            

        }
        
        public class Actions : User.Actions
        {

            public int Amount { get; set; }
            public Actions(DateTime time, Guid IdAuction,string NameAuction, int Amount) : base(time, IdAuction, NameAuction)
            {
                this.Amount = Amount;
            }

        }
        public class AuctionNotification
        {
            public string Type { get; set; }
            public string Messege { get; set; }
            public DateTime Time { get; set; }
            public Guid IdAuction { get; set; } 
            public bool isNotificationRead { get; set; }
            public AuctionNotification(string type, string message, DateTime time, Guid IdAuction, bool check)
            {
                Type = type;
                Messege = message;
                Time = time;
                this.IdAuction = IdAuction;
                isNotificationRead = check;
            }
        }
    }

}


