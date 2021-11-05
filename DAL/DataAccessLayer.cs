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

        public DataTable GetCountLogin(User user)
        {
            dbCmd = new SqlCommand("sp_GetCountLogin", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@Email", user.Email);
            dbCmd.Parameters.AddWithValue("@Password", user.Password);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetLoginUser(User user)
        {
            dbCmd = new SqlCommand("sp_GetLoginUser", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@Email", user.Email);
            dbCmd.Parameters.AddWithValue("@Password", user.Password);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

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

        public DataTable GetModuleAndYear()
        {
            dbCmd = new SqlCommand("sp_GetModuleAndYear", dbConn);
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

        public DataTable GetTopicModule()
        {
            dbCmd = new SqlCommand("sp_GetTopicModule", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetTopicModuleByUser(User user)
        {
            dbCmd = new SqlCommand("sp_GetTopicModuleByUser", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@UserID", user.UserID);
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
            dbCmd.Parameters.AddWithValue("@ErrorDate", error.ErrorDate);
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

        public int DeleteUserModule(UserModule userModule)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_DeleteUserModule", dbConn);
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

        public int UpdateModule(Module module)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_UpdateModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@ModuleID", module.ModuleID);
            dbCmd.Parameters.AddWithValue("@ModuleDesc", module.ModuleDesc);
            dbCmd.Parameters.AddWithValue("@YearID", module.YearID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int UpdateTopic(Topic topic)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_UpdateTopic", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@TopicID", topic.TopicID);
            dbCmd.Parameters.AddWithValue("@TopicDesc", topic.TopicDesc);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int DeleteModuleTopic(ModuleTopic moduleTopic)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_DeleteModuleTopic", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@ModuleTopicID", moduleTopic.ModuleTopicID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int DeleteModule(Module module)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_DeleteModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@ModuleID", module.ModuleID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int DeleteTopic(Topic topic)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_DeleteTopic", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@TopicID", topic.TopicID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int UpdateError(Error error)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_UpdateError", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@ErrorID", error.ErrorID);
            dbCmd.Parameters.AddWithValue("@ErrorDesc", error.ErrorDesc);
            dbCmd.Parameters.AddWithValue("@ProgLangID", error.ProgLangID);
            dbCmd.Parameters.AddWithValue("@ModuleTopicID", error.ModuleTopicID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int DeleteError(Error error)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_DeleteError", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@ErrorID", error.ErrorID);
            dbCmd.Parameters.AddWithValue("@ErrorStatus", error.ErrorStatus);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertSolutionError(SolutionError solutionError)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_InsertSolutionError", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@SolutionDesc", solutionError.SolutionDesc);
            dbCmd.Parameters.AddWithValue("@LecturerID", solutionError.LecturerID);
            dbCmd.Parameters.AddWithValue("@ErrorID", solutionError.ErrorID);
            dbCmd.Parameters.AddWithValue("@SolutionDate", solutionError.SolutionDate);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable GetSolutionError()
        {
            dbCmd = new SqlCommand("sp_GetSolutionError", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public int UpdateSolution(SolutionError solutionError)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_UpdateSolution", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@SolutionID", solutionError.SolutionID);
            dbCmd.Parameters.AddWithValue("@SolutionDesc", solutionError.SolutionDesc);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int DeleteSolution(SolutionError solutionError)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_DeleteSolution", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@SolutionID", solutionError.SolutionID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable GetUser()
        {
            dbCmd = new SqlCommand("sp_GetUser", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetRole()
        {
            dbCmd = new SqlCommand("sp_GetRole", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetUserModule(UserModule userModule)
        {
            dbCmd = new SqlCommand("sp_GetUserModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@UserID", userModule.UserID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public int UpdateUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_UpdateUser", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@UserID", user.UserID);
            dbCmd.Parameters.AddWithValue("@Username", user.Username);
            dbCmd.Parameters.AddWithValue("@Surname", user.Surname);
            dbCmd.Parameters.AddWithValue("@Email", user.Email);
            dbCmd.Parameters.AddWithValue("@Password", user.Password);
            dbCmd.Parameters.AddWithValue("@RoleID", user.RoleID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int DeleteUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_DeleteUser", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@UserID", user.UserID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int DeleteUserSolution(SolutionError solutionError)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_DeleteUserSolution", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@LecturerID", solutionError.LecturerID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int DeleteUserError(Error error)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_DeleteUserError", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@StudentID", error.StudentID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable GetSolutionByUser(User user)
        {
            dbCmd = new SqlCommand("sp_GetSolutionByUser", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@LecturerID", user.UserID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetErrorByUser(User user)
        {
            dbCmd = new SqlCommand("sp_GetErrorByUser", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@StudentID", user.UserID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetLeastAnswered()
        {
            dbCmd = new SqlCommand("sp_GetLeastAnswered", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetMostAnswered()
        {
            dbCmd = new SqlCommand("sp_GetMostAnswered", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable CountPending()
        {
            dbCmd = new SqlCommand("sp_CountPending", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable CountSolved()
        {
            dbCmd = new SqlCommand("sp_CountSolved", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable CountErrors()
        {
            dbCmd = new SqlCommand("sp_CountErrors", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable CountUsers()
        {
            dbCmd = new SqlCommand("sp_CountUsers", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetErrorByModule(Module module)
        {
            dbCmd = new SqlCommand("sp_GetErrorByModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@ModuleID", module.ModuleID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetSolutionByModule(Module module)
        {
            dbCmd = new SqlCommand("sp_GetSolutionByModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@ModuleID", module.ModuleID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetErrorByDate(Error error)
        {
            dbCmd = new SqlCommand("sp_GetErrorByDate", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@ErrorDateFrom", error.ErrorDateFrom);
            dbCmd.Parameters.AddWithValue("@ErrorDateTo", error.ErrorDateTo);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetSolutionByDate(SolutionError solutionError)
        {
            dbCmd = new SqlCommand("sp_GetSolutionByDate", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@SolutionDateFrom", solutionError.SolutionDateFrom);
            dbCmd.Parameters.AddWithValue("@SolutionDateTo", solutionError.SolutionDateTo);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetLecturerByStudentError(User user)
        {
            dbCmd = new SqlCommand("sp_GetLecturerByStudentError", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@StudentID", user.UserID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetLecturerSolutions(User user)
        {
            dbCmd = new SqlCommand("sp_GetLecturerSolutions", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@LecturerID", user.UserID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public int DeleteSolutionByLecturer(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_DeleteSolutionByLecturer", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@LecturerID", user.UserID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int SetErrorPending(SolutionError solutionError)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_SetErrorPending", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@SolutionID", solutionError.SolutionID);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
    }
}