using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
    public class Trainee
    {
        public string traineeName { get; set; }
        public Trainer trainer { get; set; }
        public Training training { get; set; }

    }
}
