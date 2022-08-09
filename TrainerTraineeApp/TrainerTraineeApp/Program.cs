using System;

namespace TrainerTraineeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.create topic
            Topic topic1 = new Topic() { topicName = "Variables" };
            Topic topic2 = new Topic() { topicName = "Data Types" };
            Topic topic3 = new Topic() { topicName = "if..else" };
            Topic topic4 = new Topic() { topicName = "for" };
            Topic topic5 = new Topic() { topicName = "while" };
            Topic topic6 = new Topic() { topicName = "table tab" };
            Topic topic7 = new Topic() { topicName = "form tag" };
            Topic topic8 = new Topic() { topicName = "Nav tag" };
            Topic topic9 = new Topic() { topicName = "H1 & H2 tags" };
            Topic topic10 = new Topic() { topicName = "For each" };

            //2. create unit
            Unit unit1 = new Unit() { unitName = "Control Statements", unitDuration = "30" };
            Unit unit2 = new Unit() { unitName = "HTML Basics", unitDuration = "50" };
            Unit unit3 = new Unit() { unitName = "flow control Statements", unitDuration = "60" };

            //3.Add topics to unit
            unit1.AddTopic(topic1);
            unit1.AddTopic(topic2);
            unit1.AddTopic(topic3);
            unit1.AddTopic(topic4);
            unit1.AddTopic(topic5);
            unit1.AddTopic(topic10);

            unit2.AddTopic(topic6);
            unit2.AddTopic(topic7);
            unit2.AddTopic(topic8);
            unit2.AddTopic(topic9);

            unit3.AddTopic(topic1);
            unit3.AddTopic(topic2);
            unit3.AddTopic(topic3);
            unit3.AddTopic(topic4);
            unit3.AddTopic(topic5);

            //4.Create Modules
            Module module1 = new Module() { moduleName = "C# Programming" };
            Module module2 = new Module() { moduleName = "HTML Module" };
            Module module3 = new Module() { moduleName = " Java Script Programming" };

            //5.Add unit to module
            module1.AddUnit(unit1);
            module2.AddUnit(unit2);
            module3.AddUnit(unit3);

            //6.create course
            Course course = new Course() { courseName = "Dot Net Full Stack" };

            //7.add Modules to the course
            course.AddModule(module1);
            course.AddModule(module2);
            course.AddModule(module3);

            //8.Create technology
            Technology technology = new Technology() { technologyName = "Dot Net, C#" };

            //.9.add tenchnology to course
            course.technology = technology;

            //10.Add course to Technology
            technology.course = course;

            //11.create Training
            Training training = new Training() { trainingName = "B2B .NET CORE" };

            //12.add training to course
            course.AddTraining(training);

            //13. add course to training
            training.course = course;

            //14.creating trainee;
            Trainee trainee1 = new Trainee() { traineeName = "Ben" };
            Trainee trainee2 = new Trainee() { traineeName = "Glen" };
            Trainee trainee3 = new Trainee() { traineeName = "Sam" };
            Trainee trainee4 = new Trainee() { traineeName = "Dan" };
            Trainee trainee5 = new Trainee() { traineeName = "Ron" };

            //15. Add trainee to training
            training.AddTrainee(trainee1);
            training.AddTrainee(trainee2);
            training.AddTrainee(trainee3);
            training.AddTrainee(trainee4);
            training.AddTrainee(trainee5);

            //16. Add training to trainee
            trainee1.training = training;
            trainee2.training = training;
            trainee3.training = training;
            trainee4.training = training;
            trainee5.training = training;

            //17. create trainer
            Trainer trainer = new Trainer() { trainerName = "ShashiKanth CR" };

            //18. Add Trainees to trainer
            trainer.AddTrainee(trainee1);
            trainer.AddTrainee(trainee2);
            trainer.AddTrainee(trainee3);
            trainer.AddTrainee(trainee4);
            trainer.AddTrainee(trainee5);

            //19. Add trainer to trainee
            trainee1.trainer = trainer;
            trainee2.trainer = trainer;
            trainee3.trainer = trainer;
            trainee4.trainer = trainer;
            trainee5.trainer = trainer;

            //20. Add trainer to training
            training.trainer = trainer;

            //21. Add Training to trainer
            trainer.training = training;

            //22. Display training
            DisplayTrainingInfo(training);

        }

        private static void DisplayTrainingInfo(Training training)
        {
            int trainingDuration = 0;
            Console.WriteLine("----------------Training Info---------------------");
            DrawLine("*", 20);
            Console.WriteLine($"Training Name  :   {training.trainingName}\t\tTrainer : {training.trainer.trainerName}");
            foreach (var course in training.course.GetModules())
            {
                foreach (var unit in course.GetUnits())
                {
                    trainingDuration += Convert.ToInt32(unit.unitDuration);
                }

            }
            Console.WriteLine($"Training Duration : {trainingDuration}");
            DrawLine("-", 20);
            Console.WriteLine("Trainees:");
            foreach (var trainee in training.Gettrainees())
            {
                Console.WriteLine(trainee.traineeName);
            }
            DrawLine("-", 20);
            Console.WriteLine($"Technology : {training.course.technology.technologyName}");
            Console.WriteLine($"Course Name : {training.course.courseName}\t\tcourse Duration : {trainingDuration}");
            Console.WriteLine("Module Name \t\t\t Module Duration");
            DrawLine("-", 20);
            foreach (var module in training.course.GetModules())
            {
                int moduleDuration = 0;
                foreach (var unit in module.GetUnits())
                {
                    moduleDuration += Convert.ToInt32(unit.unitDuration);
                }

                Console.WriteLine($"{module.moduleName}\t\t\t{moduleDuration}");
            }
            DrawLine("-", 20);
            Console.WriteLine("unit Name \t\t\t unit Duration");
            DrawLine("-", 20);
            foreach (var module in training.course.GetModules())
            {
                foreach (var unit in module.GetUnits())
                {
                    Console.WriteLine($"{unit.unitName}\t\t\t{unit.unitDuration}");
                }
            }
            DrawLine("-", 20);
            Console.WriteLine("Topic List");
            DrawLine("-", 20);
            foreach (var module in training.course.GetModules())
            {
                Console.WriteLine($"Module = {module.moduleName}");
                foreach (var unit in module.GetUnits())
                {
                    Console.WriteLine($"Unit Name = {unit.unitName}");
                    foreach (var topic in unit.GetTopics())
                        Console.WriteLine($"{topic.topicName}");
                }
                DrawLine("-", 20);
            }
        }

        public static void DrawLine(string symbol, int range)
        {
            for (int i = 0; i <= range; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine("\n");
        }
    }
}
