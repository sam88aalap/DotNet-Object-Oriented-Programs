using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCard
{
    public class Term
    {
        public int TermNo { get; set; }

        private List<Subjects> subjectsList = new List<Subjects>();

        //public double termAverage = 0;

        public Term(int termNo)
        {
            this.TermNo = termNo;

        }

        public void AddSubjects(Subjects subject)
        {
            this.subjectsList.Add(subject);
        }

        public IEnumerable<Subjects> GetSubjects()
        {
            return this.subjectsList;
        }

        public double GetAverageMarks()
        {
            double termAverage = 0;
            double sum = 0;
            int totalSubjects = 0;
            foreach (var item in subjectsList)
            {
                sum += item.Score;
                totalSubjects += 1;
            }

            termAverage = Math.Round(sum / totalSubjects, 2);
            return termAverage;
        }

        public string GenerateGrade()
        {
            double termAverage = GetAverageMarks();
            string grade = String.Empty;
            foreach (var item in subjectsList)
            {
                
                if (item.GetResult() == "Fail")
                {
                    grade = "F";
                    break;
                }
                    
               else if(item.GetResult() == "Pass")
                {
                    if (termAverage >= 35 && termAverage < 50)
                        grade = "C";
                    else if (termAverage >= 55 && termAverage < 70)
                        grade = "B";
                    else if (termAverage >= 70 && termAverage < 85)
                        grade = "A";
                    else if (termAverage >= 85)
                        grade = "A+";
                    else if (termAverage < 35)
                        grade = "F";
                }
     
            }

            return grade;
        }
    }
}
