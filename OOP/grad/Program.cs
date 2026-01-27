using System;
using System.Collections.Generic;
using System.Linq;

namespace codes
{
    public class Student
    {
        private string name;
        private string faculty;
        private int grade;
        private bool finished;

        
        private static Random random = new Random();

        
        public Student(string name, string faculty, bool finished)
        {
            this.name = name;
            this.faculty = faculty;
            this.finished = finished;
            this.grade = GetRandomGrade(); 
        }

        
        private int GetRandomGrade()
        {
            return random.Next(0, 101);
        }

        
        public int GetScholarship()
        {
            
            if (finished)
                return 0;


            if (grade > 50)
                return 1000;
            else
                return 500;
        }
        
        
            public int Grade
        {
            get { return grade; }
        }


        
        public void ShowInfo()
        {
            string status = finished ? "(Graduated)" : "";
            Console.WriteLine(
                "{0,-10} {1,-10} Grade: {2,-3} Scholarship: {3} {4}",
                name,
                faculty,
                grade,
                GetScholarship(),
                status
            );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>()
            {
                new Student("Ali", "Engineering", false),
                new Student("Ayse", "Medicine", true),
                new Student("Mehmet", "Law", false),
                new Student("Elif", "Arts", true)
            };

            Console.WriteLine("\n------ STUDENT LIST ------\n");
            
            double averageGrade = students.Average(s => s.Grade);
            
            foreach (Student student in students)
            {
                student.ShowInfo();
            }
            
            Console.WriteLine("\nAverage Grade: " + Math.Round(averageGrade, 2));
        }
    }
}
