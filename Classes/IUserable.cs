using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Classes
{
    public interface IUserable
    {
        public void ChangeAccountData(string newLogin, string newPass);
    }
}
