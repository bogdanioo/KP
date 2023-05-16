using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Classes
{
    public interface IUserManager
    {
        public void AddUser(string newLogin, string newPass, string newMail);
        public bool RechargeBalance(int amount);
    }
}
