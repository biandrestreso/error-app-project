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
        public DateTime ErrorDate { get; set; }
        public DateTime ErrorDateFrom { get; set; }
        public DateTime ErrorDateTo { get; set; }
        public int StudentID { get; set; }
        public int ProgLangID { get; set; }
        public int ModuleTopicID { get; set; }

        public Error(string errorDesc, string errorStatus, DateTime errorDate, int studentID, int progLangID, int moduleTopicID)
        {
            ErrorDesc = errorDesc;
            ErrorStatus = errorStatus;
            ErrorDate = errorDate;
            StudentID = studentID;
            ProgLangID = progLangID;
            //ModuleTopicID = moduleTopicID;
        }

        public Error(int errorID, string errorDesc, int progLangID, int moduleTopicID)
        {
            ErrorID = errorID;
            ErrorDesc = errorDesc;
            ProgLangID = progLangID;
            ModuleTopicID = moduleTopicID;
        }

        public Error(int errorID)
        {
            ErrorID = errorID;
        }

        public Error(int studentID, double placeholder)
        {
            StudentID = studentID;
        }

        public Error(DateTime errorDateFrom, DateTime errorDateTo)
        {
            ErrorDateFrom = errorDateFrom;
            ErrorDateTo = errorDateTo;
        }

        public Error(int errorID, string errorStatus)
        {
            ErrorID = errorID;
            ErrorStatus = errorStatus;
        }
    }
}
