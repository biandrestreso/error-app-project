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

        public DataTable GetTopic()
        {
            return dal.GetTopic();
        }

        public DataTable GetYear()
        {
            return dal.GetYear();
        }

        public DataTable GetModuleByYear(Module module)
        {
            return dal.GetModuleByYear(module);
        }

        public DataTable GetTopicModule()
        {
            return dal.GetTopicModule();
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
    }
}
