using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCard
{
    public class Subjects
    {
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int Score { get; set; }
        public int MinScore { get; set; }

        public Subjects(string subjectCode,string subjectName, int score, int minScore)
        {
            this.SubjectCode = subjectCode;
            this.SubjectName = subjectName;
            this.Score = score;
            this.MinScore = minScore;
        }

        public String GetResult()
        {
            return (Score >= MinScore) ? "Pass" : "Fail";
        }
    }
}
