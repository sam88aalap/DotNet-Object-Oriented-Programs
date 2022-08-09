using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
    public class Course
    {
        public string courseName { get; set; }
        public Technology technology { get; set; }
        private List<Module> modules = new List<Module>();
        private List<Training> training = new List<Training>();

        public void AddModule(Module module)
        {
            this.modules.Add(module);
        }
        public IEnumerable<Module> GetModules()
        {
            return this.modules;
        }

        public void AddTraining(Training training)
        {
            this.training.Add(training);
        }
        public IEnumerable<Training> GetTrainings()
        {
            return this.training;
        }
    }
}
