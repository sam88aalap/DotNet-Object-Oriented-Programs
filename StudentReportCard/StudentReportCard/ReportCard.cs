using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCard
{
    public class ReportCard
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public IEnumerable<Student> GetStudent()
        {
            return this.students;
        }
    }
}
