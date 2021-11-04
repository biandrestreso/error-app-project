using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Module
    {
        public int ModuleID { get; set; }
        public string ModuleDesc { get; set; }
        public int YearID { get; set; }

        public Module(int yearID)
        {
            YearID = yearID;
        }

        public Module(string moduleDesc, int yearID)
        {
            ModuleDesc = moduleDesc;
            YearID = yearID;
        }
    }
}
