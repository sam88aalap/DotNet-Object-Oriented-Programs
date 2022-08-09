using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
    public class Trainer
    {
        public string trainerName { get; set; }
        public Training training { get; set; }
        private List<Trainee> trainees = new List<Trainee>();

        public void AddTrainee(Trainee trainee)
        {
            this.trainees.Add(trainee);
        }

        public IEnumerable<Trainee> GetTrainees()
        {
            return this.trainees;
        }
    }
}
