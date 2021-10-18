using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessLayer
    {
        static string connString = "Data Source = localhost; Initial Catalog = CarDB; Integrated Security = true";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;
        DataTable dt;
    }
}
