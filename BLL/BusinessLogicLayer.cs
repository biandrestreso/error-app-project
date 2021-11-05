using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        public DataTable GetCountLogin(User user)
        {
            return dal.GetCountLogin(user);
        }

        public DataTable GetLoginUser(User user)
        {
            return dal.GetLoginUser(user);
        }

        public DataTable GetError()
        {
            return dal.GetError();
        }

        public DataTable GetProgLang()
        {
            return dal.GetProgLang();
        }

        public DataTable GetModule()
        {
            return dal.GetModule();
        }

        public DataTable GetModuleAndYear()
        {
            return dal.GetModuleAndYear();
        }

        public DataTable GetTopic()
        {
            return dal.GetTopic();
        }

        public DataTable GetYear()
        {
            return dal.GetYear();
        }

        public DataTable GetTopicModule()
        {
            return dal.GetTopicModule();
        }

        public DataTable GetTopicModuleByUser(User user)
        {
            return dal.GetTopicModuleByUser(user);
        }

        public DataTable GetModuleTopic()
        {
            return dal.GetModuleTopic();
        }

        public int InsertError(Error error)
        {
            return dal.InsertError(error);
        }

        public int InsertUser(User user)
        {
            return dal.InsertUser(user);
        }

        public int InsertUserModule(UserModule userModule)
        {
            return dal.InsertUserModule(userModule);
        }

        public int DeleteUserModule(UserModule userModule)
        {
            return dal.DeleteUserModule(userModule);
        }

        public int InsertModule(Module module)
        {
            return dal.InsertModule(module);
        }

        public int InsertTopic(Topic topic)
        {
            return dal.InsertTopic(topic);
        }

        public int InsertModuleTopic(ModuleTopic moduleTopic)
        {
            return dal.InsertModuleTopic(moduleTopic);
        }

        public int UpdateModule(Module module)
        {
            return dal.UpdateModule(module);
        }

        public int UpdateTopic(Topic topic)
        {
            return dal.UpdateTopic(topic);
        }

        public int DeleteModuleTopic(ModuleTopic moduleTopic)
        {
            return dal.DeleteModuleTopic(moduleTopic);
        }

        public int DeleteModule(Module module)
        {
            return dal.DeleteModule(module);
        }

        public int DeleteTopic(Topic topic)
        {
            return dal.DeleteTopic(topic);
        }

        public int DeleteError(Error error)
        {
            return dal.DeleteError(error);
        }

        public int UpdateError(Error error)
        {
            return dal.UpdateError(error);
        }

        public int InsertSolutionError(SolutionError solutionError)
        {
            return dal.InsertSolutionError(solutionError);
        }

        public DataTable GetSolutionError()
        {
            return dal.GetSolutionError();
        }

        public int UpdateSolution(SolutionError solutionError)
        {
            return dal.UpdateSolution(solutionError);
        }

        public int DeleteSolution(SolutionError solutionError)
        {
            return dal.DeleteSolution(solutionError);
        }

        public DataTable GetUser()
        {
            return dal.GetUser();
        }

        public DataTable GetRole()
        {
            return dal.GetRole();
        }

        public DataTable GetUserModule(UserModule userModule)
        {
            return dal.GetUserModule(userModule);
        }

        public int UpdateUser(User user)
        {
            return dal.UpdateUser(user);
        }

        public int DeleteUser(User user)
        {
            return dal.DeleteUser(user);
        }

        public int DeleteUserSolution(SolutionError solutionError)
        {
            return dal.DeleteUserSolution(solutionError);
        }

        public int DeleteUserError(Error error)
        {
            return dal.DeleteUserError(error);
        }

        public int SetErrorPending(SolutionError solutionError)
        {
            return dal.SetErrorPending(solutionError);
        }

        public DataTable GetLecturerByStudentError(User user)
        {
            return dal.GetLecturerByStudentError(user);
        }

        public DataTable GetLecturerSolutions(User user)
        {
            return dal.GetLecturerSolutions(user);
        }

        public int DeleteSolutionByLecturer(User user)
        {
            return dal.DeleteSolutionByLecturer(user);
        }

        public DataTable GetSolutionByUser(User user)
        {
            return dal.GetSolutionByUser(user);
        }

        public DataTable GetErrorByUser(User user)
        {
            return dal.GetErrorByUser(user);
        }

        public DataTable GetLeastAnswered()
        {
            return dal.GetLeastAnswered();
        }

        public DataTable GetMostAnswered()
        {
            return dal.GetMostAnswered();
        }

        public DataTable CountPending()
        {
            return dal.CountPending();
        }

        public DataTable CountSolved()
        {
            return dal.CountSolved();
        }

        public DataTable CountErrors()
        {
            return dal.CountErrors();
        }

        public DataTable CountUsers()
        {
            return dal.CountUsers();
        }

        public DataTable GetErrorByModule(Module module)
        {
            return dal.GetErrorByModule(module);
        }

        public DataTable GetSolutionByModule(Module module)
        {
            return dal.GetSolutionByModule(module);
        }

        public DataTable GetErrorByDate(Error error)
        {
            return dal.GetErrorByDate(error);
        }

        public DataTable GetSolutionByDate(SolutionError solutionError)
        {
            return dal.GetSolutionByDate(solutionError);
        }
    }
}