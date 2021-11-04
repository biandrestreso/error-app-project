using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Topic
    {
        public string TopicID { get; set; }
        public string TopicDesc { get; set; }

        public Topic(string topicDesc)
        {
            TopicDesc = topicDesc;
        }
    }
}
