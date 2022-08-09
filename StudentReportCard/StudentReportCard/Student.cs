using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCard
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        private List<Term> terms = new List<Term>();

        public Student(int studentId, string studentName)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
        }

        public IEnumerable<Term> GetTerms()
        {
            return this.terms;
        }

        public void AddTerm(Term term)
        {
            this.terms.Add(term);
        }
    }
}
