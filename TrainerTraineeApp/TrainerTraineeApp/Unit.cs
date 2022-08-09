using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
    public class Unit
    {
        public string unitName { get; set; }
        public string unitDuration { get; set; }
        private List<Topic> topics = new List<Topic>();

        public void AddTopic(Topic topic)
        {
            this.topics.Add(topic);
        }
        public IEnumerable<Topic> GetTopics()
        {
            return this.topics;
        }
    }
}
