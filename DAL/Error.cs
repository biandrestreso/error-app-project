using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Error
    {
        public int ErrorID { get; set; }
        public string ErrorDesc { get; set; }
        public string ErrorStatus { get; set; }
        public int StudentID { get; set; }
        public int ProgLangID { get; set; }
        public int ModuleTopicID { get; set; }

        public Error(string errorDesc, string errorStatus, int studentID, int progLangID, int moduleTopicID)
        {
            ErrorDesc = errorDesc;
            ErrorStatus = errorStatus;
            StudentID = studentID;
            ProgLangID = progLangID;
            ModuleTopicID = moduleTopicID;
        }
    }
}
