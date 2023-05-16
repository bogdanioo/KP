using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace KP.Classes
{
    public interface IAdministration
    {

        public void AddAuction(string newName, string newDescription, string newim, string newMin, string newStep, string newN, string newK, string type);
        public bool RemoveAuction(OnlineAuctionSystem auction);

    }
}
