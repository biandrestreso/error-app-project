using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserModule
    {
        public int UserID { get; set; }
        public int ModuleID { get; set; }

        public UserModule(int userID, int moduleID)
        {
            UserID = userID;
            ModuleID = moduleID;
        }
    }
}
