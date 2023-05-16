using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KP.Classes
{
    public class Administrator : User, IAdministration
    {
        public List<Actions> actions = new List<Actions>();
        public Administrator(string username, string password)
        {
            this.username = username;
            this.password = password;
        }


        public void AddAuction(string newName, string newDescription, string newim, string newMin, string newStep, string newBegin, string newEnd, string type)
        {


            DateTime res, res2;
            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newDescription) || string.IsNullOrEmpty(newMin) || string.IsNullOrEmpty(newBegin) || string.IsNullOrEmpty(newEnd) || string.IsNullOrEmpty(newStep) || string.IsNullOrEmpty(type)
               )
            {



                throw new ArgumentException("Всі поля повинні бути заповненими!");
                


            }
            if (newim == "")
            {
                throw new ArgumentException("Додайте зображення");
                
            }
            if (DateTime.TryParseExact(newBegin, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out res))
            {
                if (res < DateTime.Now)
                {
                    throw new ArgumentException("Невірно введена дата початку аукціону!");
                }


            }
            else
            {
                throw new ArgumentException("Невірний формат дати! Повинен бути: dd.MM.yyyy HH:mm ");
                
            }
            if (DateTime.TryParseExact(newEnd, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out res2))
            {
                
                if (res2 < DateTime.Now.AddDays(1))
                {
                    throw new ArgumentException("Невірно введена дата кінця аукціону. Аукціон повинен тривати не менше доби.");
                    
                }
                
            }
            else
            {
                throw new ArgumentException("Невірний формат дати! Повинен бути: dd.MM.yyyy HH:mm ");
            }


            OnlineAuctionSystem auction = new(newName, newim, newDescription, Convert.ToInt16(newMin), Convert.ToInt32(newStep), res, res2, type,Guid.NewGuid());
            //auction.image=Image.FromFile(newim);
            OnlineAuction.Auctions.Add(auction);
            AddActions("Додавання", auction.Id,auction.name);
          
           


        }

        public bool RemoveAuction(OnlineAuctionSystem auction)
        {
            if (auction.startAuction > DateTime.Now)
            {

                int index = OnlineAuction.Auctions.FindIndex(u => u == auction);
                OnlineAuction.Auctions.Remove(auction);
                AddActions("Видалення", auction.Id,auction.name);
                
                return true;
            }

            return false;


        }

        public void AddActions(string action, Guid auction,string name)
        {
            Actions b = new Actions(DateTime.Now, auction, action,name);
            actions.Add(b);
            
        }
      

        public class Actions : User.Actions
        {

            public string action { get; set; }
            public Actions(DateTime time, Guid auction, string action,string name) : base(time,auction, name)
            {
                this.action = action;
            }





        }
    }


}
