using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ModuleTopic
    {
        public int ModuleTopicID { get; set; }
        public int ModuleID { get; set; }
        public int TopicID { get; set; }

        public ModuleTopic(int moduleID, int topicID)
        {
            ModuleID = moduleID;
            TopicID = topicID;
        }

        public ModuleTopic(int moduleTopicID)
        {
            ModuleTopicID = moduleTopicID;
        }
    }
}
