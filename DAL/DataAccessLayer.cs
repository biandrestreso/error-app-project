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
        static string connString = "Data Source = localhost; Initial Catalog = ErrorDB; Integrated Security = true";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        public DataTable GetError()
        {
            dbCmd = new SqlCommand("sp_GetError", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetProgLang()
        {
            dbCmd = new SqlCommand("sp_GetProgLang", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetYear()
        {
            dbCmd = new SqlCommand("sp_GetYear", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetModule()
        {
            dbCmd = new SqlCommand("sp_GetModule", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetTopic()
        {
            dbCmd = new SqlCommand("sp_GetTopic", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetModuleByYear(Module module)
        {
            dbCmd = new SqlCommand("sp_GetModuleByYear", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@YearID", module.YearID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetTopicModule()
        {
            dbCmd = new SqlCommand("sp_GetTopicModule", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetModuleTopic()
        {
            dbCmd = new SqlCommand("sp_GetModuleTopic", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public int InsertError(Error error)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_InsertError", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@ErrorDesc", error.ErrorDesc);
            dbCmd.Parameters.AddWithValue("@ErrorStatus", error.ErrorStatus);
            dbCmd.Parameters.AddWithValue("@StudentID", error.StudentID);
            dbCmd.Parameters.AddWithValue("@ProgLangID", error.ProgLangID);
            dbCmd.Parameters.AddWithValue("@ModuleTopicID", error.ModuleTopicID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_InsertUser", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Username", user.Username);
            dbCmd.Parameters.AddWithValue("@Surname", user.Surname);
            dbCmd.Parameters.AddWithValue("@Email", user.Email);
            dbCmd.Parameters.AddWithValue("@Password", user.Password);
            dbCmd.Parameters.AddWithValue("@RoleID", user.RoleID);

            int x = (int)dbCmd.ExecuteScalar();
            return x;
        }

        public int InsertUserModule(UserModule userModule)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_InsertUserModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@UserID", userModule.UserID);
            dbCmd.Parameters.AddWithValue("@ModuleID", userModule.ModuleID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertModule(Module module)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_InsertModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@ModuleDesc", module.ModuleDesc);
            dbCmd.Parameters.AddWithValue("@YearID", module.YearID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertTopic(Topic topic)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_InsertTopic", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@TopicDesc", topic.TopicDesc);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertModuleTopic(ModuleTopic moduleTopic)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_InsertModuleTopic", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@ModuleID", moduleTopic.ModuleID);
            dbCmd.Parameters.AddWithValue("@TopicID", moduleTopic.TopicID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
    }
}
