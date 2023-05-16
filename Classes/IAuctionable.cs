using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Classes
{
    public interface IAuctionable
    {
        public string ViewBids();
        public void AddBid(int  idUser, int bid, DateTime date);
        public string CalculateWinner();
    }
}
