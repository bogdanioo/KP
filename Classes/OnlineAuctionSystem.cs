using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KP.Classes
{
    public class OnlineAuctionSystem : Auction, IAuctionable
    {
       
        public List<BidAuction> bids = new List<BidAuction>();
      

        public OnlineAuctionSystem(string name, string image, string description, int startingPrice, int rateStep, DateTime startAuction, DateTime endAuction, string itemType, Guid id) : base(name, image, description, startingPrice, rateStep, startAuction, endAuction, itemType,id)
        {

        }
        public string ViewBids()
        {

            if (bids.Count != 0)
            {
                string res = "";
                for (int i = 0; i < bids.Count(); i++)
                {
                    AuthorizedUser user = OnlineAuction.Users.FirstOrDefault(a => a.Id == bids[i].Iduser);
                    res += user.username + " " + +bids[i].Amount + " " + bids[i].Time + "\r\n";
                }
                return res;
            }
            return "Ставки відсутні!";
        }

        public void AddBid(int idUser, int bid, DateTime date)
        {
            AuthorizedUser user = OnlineAuction.Users.FirstOrDefault(a => a.Id == idUser);

            if (bid < startingPrice)
            {
                throw new InvalidOperationException("Ви не можете зробити ставку, менше мінімальної");

            }
            if (bid <= currentPrice)
            {
                throw new InvalidOperationException("Ви не можете зробити ставку, менше останньої");

            }
            if (bid < currentPrice + rateStep)
            {
                throw new InvalidOperationException("Крок ставки " + rateStep + " грн!");

            }
            if (bid > user.balance)
            {
                throw new InvalidOperationException("Недостатньо коштів на балансі");

            }
            TimeSpan timeleft = endAuction - DateTime.Now;
            if (timeleft.TotalMinutes < 5)
            {

                endAuction = endAuction.AddMinutes(5);


            }

            if(bids.Count>0)
            {
                AuthorizedUser userPreviousBid = OnlineAuction.Users.FirstOrDefault(a => a.Id == bids[bids.Count-1].Iduser);
                userPreviousBid.balance += bids[bids.Count - 1].Amount;
            }
            
            BidAuction bidAuction = new BidAuction(user.Id, bid, date);
            {
                if (bids.Count > 0)
                {
                    if (bids[bids.Count - 1].Iduser != user.Id)
                    {
                        AuthorizedUser userPreviousBid = OnlineAuction.Users.FirstOrDefault(a => a.Id == bids[bids.Count - 1].Iduser);
                        userPreviousBid.Notification.Add(new AuthorizedUser.AuctionNotification("Вашу ставку перебили", user.username + " зробив ставку у розмірі " + bid + "грн ", DateTime.Now, this.Id, false));
                       // OnlineAuction.SaveToUsers();
                    }
                }
            }
            bids.Add(bidAuction);

            user.balance -= bid;
            user.AddActions(this.Id, this.name, bid);
            currentPrice = bid;
            
        }

        public override string CalculateWinner()
        {
           

            if (bids.Count> 0)
            {


                winner =bids[bids.Count - 1].Iduser;
             
                AuthorizedUser User = OnlineAuction.Users.FirstOrDefault(a => a.Id == winner);
                User.Notification.Add(new AuthorizedUser.AuctionNotification("Ви виграли лот", "Назва  - " + name, DateTime.Now, this.Id, false));
               

                if (winner == OnlineAuction.Users[OnlineAuction.userId].Id)
                {
                   
                   return ("Вы перемогли!");

                }
                else
                {


                    AuthorizedUser Userr = OnlineAuction.Users.FirstOrDefault(a => a.Id == bids[bids.Count - 1].Iduser);
                    return ("Переміг - " + Userr.username + " зі ставкою " + bids[bids.Count - 1].Amount + " грн");
                }
                

                

            }
            
            else
            {
                winner = -1;
                
                return ("Ставок не було");
                
            }

                

            } }
        public class BidAuction
        {
     
            public int Iduser { get; set; }
           
            public int Amount { get; set; }
            public DateTime Time { get; set; }
            public BidAuction(int user, int amount, DateTime time)
            {
                this.Iduser = user;
                Amount = amount;
                Time = time;
            }
        }


    }

