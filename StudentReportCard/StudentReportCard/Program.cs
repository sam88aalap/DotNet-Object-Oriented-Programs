using System;
using System.Collections.Generic;

namespace StudentReportCard
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Adding Subject Details
            Subjects subject1 = new Subjects("CS101", "Data Structures", 90, 45);
            Subjects subject2 = new Subjects("MA101", "Linear Algebra", 80, 45);
            Subjects subject3 = new Subjects("CS102", "DataBase", 50, 45);
            Subjects subject4 = new Subjects("CS103", "Operating Systems", 60, 45);
            Subjects subject5 = new Subjects("CS104", "Digital Circuits", 30, 45);
            Subjects subject6 = new Subjects("CS105", "Web Technology", 90, 45);
            Subjects subject7 = new Subjects("CS106", "Compiler Design", 75, 45);
            Subjects subject8 = new Subjects("CS107", "Machine Learning", 85, 45);
            Subjects subject9 = new Subjects("CS108", "Programing Paradigms", 60, 45);
            Subjects subject10 = new Subjects("CS109", "Cryptography", 55, 45);

            //Adding Term Details
            Term term1 = new Term(1);
            Term term2 = new Term(2);

            term1.AddSubjects(subject1);
            term1.AddSubjects(subject2);
            term1.AddSubjects(subject3);
            term1.AddSubjects(subject4);
            term1.AddSubjects(subject5);

            term2.AddSubjects(subject6);
            term2.AddSubjects(subject7);
            term2.AddSubjects(subject8);
            term2.AddSubjects(subject9);
            term2.AddSubjects(subject10);

            //Adding Student Details
            Student student1 = new Student(101, "Sam Jacob");
            Student student2 = new Student(102, "Tom Hardy");

            student1.AddTerm(term1);
            student2.AddTerm(term2);

            ReportCard reportCard = new ReportCard();

            reportCard.AddStudent(student1);
            reportCard.AddStudent(student2);

            DisplayReportCard(reportCard);
        }

        private static void DisplayReportCard(ReportCard reportCard)
        {
            Console.WriteLine("Student Report");
            DrawLine(10, "-");
            foreach (var student in reportCard.GetStudent())
            {
                Console.WriteLine($"Student ID: {student.StudentId}\tStudent Name:{student.StudentName}\n");
                foreach (var term in student.GetTerms())
                {
                    Console.WriteLine($"Term {term.TermNo}");
                    DrawLine(20, "-");
                    Console.WriteLine("Subject Code\tMin\tMark\tResult");
                    DrawLine(20, "-");
                    foreach (var subject in term.GetSubjects())
                    {
                        Console.WriteLine($"{subject.SubjectCode}\t\t{subject.MinScore}\t{subject.Score}\t{subject.GetResult()}");
                    }
                    DrawLine(20, "-");
                    Console.WriteLine($"Result:{term.GenerateGrade()}");
                }

                DrawLine(20, "-");
            }
        }

        private static void DrawLine(int v1, string v2)
        {
            int i = 0;
            while (i < v1)
            {
                Console.Write($"{v2}");
                i++;
            }
            Console.WriteLine();
        }
    }
}


