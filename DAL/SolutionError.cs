using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SolutionError
    {
        public int SolutionID { get; set; }
        public string SolutionDesc { get; set; }
        public int LecturerID { get; set; }
        public int ErrorID { get; set; }
        public DateTime SolutionDate { get; set; }
        public DateTime SolutionDateFrom { get; set; }
        public DateTime SolutionDateTo { get; set; }

        public SolutionError(string solutionDesc, int lecturerID, int errorID, DateTime solutionDate)
        {
            SolutionDesc = solutionDesc;
            LecturerID = lecturerID;
            ErrorID = errorID;
            SolutionDate = solutionDate;
        }

        public SolutionError(int solutionID)
        {
            SolutionID = solutionID;
        }

        public SolutionError(int lecturerID, double placeholder)
        {
            LecturerID = lecturerID;
        }

        public SolutionError(int solutionID, string solutionDesc)
        {
            SolutionID = solutionID;
            SolutionDesc = solutionDesc;
        }

        public SolutionError(DateTime solutionDateFrom, DateTime solutionDateTo)
        {
            SolutionDateFrom = solutionDateFrom;
            SolutionDateTo = solutionDateTo;
        }
    }
}
