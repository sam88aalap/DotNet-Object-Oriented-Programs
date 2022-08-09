using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
    public class Training
    {
        public string trainingName { get; set; }
        public Course course { get; set; }
        public Trainer trainer { get; set; }
        private List<Trainee> trainees = new List<Trainee>();

        public void AddTrainee(Trainee trainee)
        {
            this.trainees.Add(trainee);
        }

        public IEnumerable<Trainee> Gettrainees()
        {
            return this.trainees;
        }
    }
}
