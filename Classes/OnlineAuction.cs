using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using System.Text.Json;
//using Newtonsoft.Json;
using System.Text.Json;
using System.IO;
using System.Security.Principal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KP.Classes
{
    public class OnlineAuction
    {


        public static int userId;
        public static string userType;
        public static List<AuthorizedUser> Users = new List<AuthorizedUser>();
        public static List<OnlineAuctionSystem> Auctions = new List<OnlineAuctionSystem>();
        public static List<Administrator> Admins = new List<Administrator>();
        public static List<OnlineAuctionSystem> PastAuctions = new List<OnlineAuctionSystem>();
        
        public static void SaveToState()

        {
            JObject state = new JObject();
            state["userId"] = OnlineAuction.userId;
            state["userType"] = OnlineAuction.userType;
            string json = JsonConvert.SerializeObject(state);
            File.WriteAllText(@"D:\OnlineAuction\State.json", json);

        }
        public static void ReadToState()
        {
            if (File.Exists(@"D:\OnlineAuction\State.json"))
            {
                string json = File.ReadAllText(@"D:\OnlineAuction\State.json");
                JObject state = JObject.Parse(json);
                userId = (int)state["userId"];
                userType = (string)state["userType"];
            }

        }
        public static void SaveToUsers()
        {
            string jsonstring = JsonConvert.SerializeObject(Users);
            File.WriteAllText(@"D:\OnlineAuction\Users.json", jsonstring);
        }

            public static void SaveToAuctions()
            {
                string jsonstring = JsonConvert.SerializeObject(Auctions);
                File.WriteAllText(@"D:\OnlineAuction\Auctions.json", jsonstring);
            }

        public static void SaveToAdmins()
        {
            string jsonstring = JsonConvert.SerializeObject(Admins);
            File.WriteAllText(@"D:\OnlineAuction\Admins.json", jsonstring);
        }

        public static void SaveToPastAuctions()
        {
            string jsonstring = JsonConvert.SerializeObject(PastAuctions);
            File.WriteAllText(@"D:\OnlineAuction\PastAuctions.json", jsonstring);
        }

        public static void ReadToUsers()
        {
            if (File.Exists(@"D:\OnlineAuction\Users.json"))
            {
                string jsonstring = File.ReadAllText(@"D:\OnlineAuction\Users.json");
                Users = JsonConvert.DeserializeObject<List<AuthorizedUser>>(jsonstring);
            }
        }

        public static void ReadToAuctions()
        {
            if (File.Exists(@"D:\OnlineAuction\Auctions.json"))
            {

                string jsonstring = File.ReadAllText(@"D:\OnlineAuction\Auctions.json");
                Auctions = JsonConvert.DeserializeObject<List<OnlineAuctionSystem>>(jsonstring);

               
            }

        }

        public static void ReadToAdmins()
        {
            if (File.Exists(@"D:\OnlineAuction\Admins.json"))
            {
                string jsonstring = File.ReadAllText(@"D:\OnlineAuction\Admins.json");
                Admins = JsonConvert.DeserializeObject<List<Administrator>>(jsonstring);
            }
        }

        public static void ReadToPastAuctions()
        {
            if (File.Exists(@"D:\OnlineAuction\PastAuctions.json"))
            {
                string jsonstring = File.ReadAllText(@"D:\OnlineAuction\PastAuctions.json");
                PastAuctions = JsonConvert.DeserializeObject<List<OnlineAuctionSystem>>(jsonstring);
                
            }
        }










        static OnlineAuction()
        {
            if (!File.Exists(@"D:\OnlineAuction\Admins.json"))
            {
                Admins.Add(new Administrator("admin1", "admin1"));
                Admins.Add(new Administrator("admin2", "admin2"));
                Admins.Add(new Administrator("admin3", "admin3"));
                if (!Directory.Exists(@"D:\OnlineAuction\"))
                {
                    Directory.CreateDirectory(@"D:\OnlineAuction\");
                }
                
            }
            

        }



        public static bool Authorized(string username, string password)
        {
            int index = Users.FindIndex(u => u.username == username && u.password == password);
            if (index != -1)
            {
               
                userType = "User";

                userId = index;              
                return true;

            }
            else
            {
                index = Admins.FindIndex(u => u.username == username && u.password == password);
            }
            if (index == -1)
            {
                return false;
                
            }
            else
            {
                userType = "Admin";
                userId = index;
                
            }
            
            return true;
        }
     




    }
 
}
