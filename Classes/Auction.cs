using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;

namespace KP.Classes
{

    public abstract class Auction
    {
        
        
        public Guid Id { get; set; }
        private string Name;

      

        private string Description;
        private int StartingPrice;
        private int CurrentPrice;
        private int RateStep;
        private DateTime StartAuction;
        private DateTime EndAuction;
        private int Winner;
        private AuctionItemType itemType;
        public abstract string CalculateWinner();

        public Auction(string name,string image, string description, int startingPrice, int rateStep, DateTime startAuction, DateTime endAuction, string itemType,Guid id)
        {
            Name = name;
            ImageFileName = image;
            Description = description;
            StartingPrice = startingPrice;
            RateStep = rateStep;
            StartAuction = startAuction;
            EndAuction = endAuction;
            this.ItemType = itemType;
          
            Id = id;
           
            
        }

        public string ItemType
        {
            get
            {
                switch (itemType)
                {
                    case AuctionItemType.Drawing:
                        return "Малювання";
                    case AuctionItemType.Sculpture:
                        return "Скульптура";
                    case AuctionItemType.Jewelry:
                        return "Ювелірні вироби";
                    case AuctionItemType.Antiques:
                        return "Антикваріат";
                    case AuctionItemType.Collecting:
                        return "Колекціонування";
                    case AuctionItemType.Fashion:
                        return "Мода";
                    case AuctionItemType.Technology:
                        return "Технології";
                    default:
                        return "Інше";
                }
            }


            set
            {

                switch (value)
                {
                    case "Малювання":
                        itemType = AuctionItemType.Drawing;
                        break;
                    case "Скульптура":
                        itemType = AuctionItemType.Sculpture;
                        break;
                    case "Ювелірні вироби":
                        itemType = AuctionItemType.Jewelry;
                        break;
                    case "Антикваріат":
                        itemType = AuctionItemType.Antiques;
                        break;
                    case "Колекціонування":
                        itemType = AuctionItemType.Collecting;
                        break;
                    case "Мода":
                        itemType = AuctionItemType.Fashion;
                        break;
                    case "Технології":
                        itemType = AuctionItemType.Technology;
                        break;
                    case "Інше":
                        itemType = AuctionItemType.Other;
                        break;

                }


            }
        }

        public int winner
        {
            get
            {
                return Winner;
            }
            set
            {
                Winner = value;
            }
        }
        [JsonIgnore]
        public string NameWinner
        {
            get
            {
                if (Winner != -1)
                {

                    AuthorizedUser User = OnlineAuction.Users.FirstOrDefault(a => a.Id == Winner);
                    return User.username;
                }
                return "Відсутній";
            }
            

        }
        [JsonIgnore]
        public string MailWinner
        {
            get
            {   if (Winner != -1)
                {
                    AuthorizedUser user = OnlineAuction.Users.FirstOrDefault(a => a.Id == Winner);
                    return user.mail;
                }
                return "-";


            }
            

        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string ImageFileName { get; set; }
        [JsonIgnore]
        public Image image
        {
            get { return Image.FromFile(ImageFileName); }
            //set { Image = value;  }
        }
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }
        public int startingPrice
        {
            get { return StartingPrice; }
            set { StartingPrice = value; }
        }
        public int currentPrice
        {
            get { return CurrentPrice; }
            set { CurrentPrice = value; }
        }

        public int rateStep
        {
            get { return RateStep; }
            set { RateStep = value; }
        }
        public DateTime startAuction
        {
            get { return StartAuction; }
            set { StartAuction = value; }
        }
        public DateTime endAuction
        {
            get { return EndAuction; }
            set { EndAuction = value; }
        }




    }

}
