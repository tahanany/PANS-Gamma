using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace codes
{

public class Student
{
    private string _name;
    private string _faculty;
    private int _grade;
    private string _studentID;
    public static int countr = 0;


    static int getNum()
    {
        Random random = new Random();
        int number;
        number = random.Next(0, 100);
        return number;
    }

    static int getRandomID()
    {
        Random random = new Random();
        int number;
        number = random.Next(999, 1500);
        return number;
    }



    public Student(string name, string faculty, string id)
    {
        _name = name;
        _faculty = faculty;
        _grade = getNum();
        countr += 1;
        _studentID = id;

    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string faculty
    {
        get { return _faculty; }
        set { _faculty = value; }
    }
    public string id
    {
        get { return _studentID; }
        set { _studentID = value; }
    }
    public int grade
    {
        get { return _grade; }
        set { _grade = value; }
    }


    public double calcAvgGra()
    {
        int avg = 0;
        for (int i = 0; i < countr; i++)
        {
            avg += grade;

        }
        avg = avg / 5;
        return avg;
    }


    public static void showStudents(List<Student> students)
    {
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine("{0} {1} {2} {3}", students[i].name, students[i].faculty, students[i].grade, students[i].id);
        }



    }

    public static void CreateID(List<string> ids, int n)
    {
        int count = 0;
        string piece = "";


        while (count < n)
        {
            piece = getRandomID().ToString();
            if (ids.Contains(piece) == false)
            {
                ids.Add(piece);
                count++;
            }
        }
    }

}

class Program
{


    static void DeleteStd(List<Student> studentLst, string studentName)
    {
        for (int i = 0; i < studentLst.Count; i++)
        {
            if (studentLst[i].name == studentName)
            {
                studentLst.RemoveAt(i);
                Student.countr--;
            }
        }
    }


    delegate string StudentResult(Student stud, int from, int to);
    delegate string StudentGrade(Student student);
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int numOfstd = 5;
        List<string> idList = new List<string>(); //create a list for IDs
        Student.CreateID(idList, numOfstd);
        List<Student> studLst = new List<Student>();

        Student std = new Student("Cenk", "Faculty of Engineering", idList[0]);
        Student std2 = new Student("Ali", "Faculty of Arts", idList[1]);
        Student std3 = new Student("Veli", "Faculty of Science", idList[2]);
        Student std4 = new Student("Ayse", "Faculty of Medicine", idList[3]);
        Student std5 = new Student("Fatma", "Faculty of Law", idList[4]);

        studLst.Add(std);
        studLst.Add(std2);
        studLst.Add(std3);
        studLst.Add(std4);
        studLst.Add(std5);

        // for (int i = 0; i < numOfstd; i++)
        // {
        //     Student std = new Student("student" + i, "Faculty of Eng", idList[i]);
        //     studLst.Add(std);

        // }




        Student.showStudents(studLst);




        Console.WriteLine($"We have {Student.countr} Students");


        double avg = 0;
        for (int i = 0; i < Student.countr; i++)
        {
            avg += studLst[i].grade;

        }
        avg = avg / 5;
        Console.WriteLine($"Average Grade is : {avg}");

        DeleteStd(studLst, "student0");


        var result = from x in studLst
                     orderby x.name
                     group x by x.name;


        foreach (Student x in studLst)
        {
            Console.WriteLine($"{x.name}, {x.grade}");
        }

        if (avg < 50)
        {
            Console.WriteLine("Average grade is less than 50");
        }
        else if (avg > 50)
        {
            Console.WriteLine("Average grade is greater than 50");
        }

        Console.WriteLine("\n-------------------");


        //StudentGrade IsGradeHigher= s=> (s.grade>50) ? "Yes it is bigger than 50" : "No, its less than 50";

        StudentGrade IsStudentHigherThanAvg = s => (s.grade > avg) ? s.name + " is higher than average" : s.name + " is less than average";

        foreach (Student student in studLst)
        {
            Console.WriteLine(IsStudentHigherThanAvg(student));
        }

        Console.WriteLine("\n-------------------");

        StudentResult canStudy = (s, from, to) => (s.grade > from && s.grade < to) ? s.name + " can study " + s.faculty
        : s.name + " can not study " + s.faculty;


        foreach (Student stud in studLst)
        {
            Console.WriteLine(canStudy(stud, 50, 100));
        }

        Console.WriteLine("\n-------------------");


        var result1 = from x in studLst
                      where x.faculty.Contains("Faculty of Engineering")
                      select x;

    
        foreach (Student x in result1)
        {   
            Console.WriteLine($"{x.name}, {x.faculty}");
        }   

        // studLst.Sort((x, y) => y.grade.CompareTo(x.grade));
        // Console.WriteLine(studLst[0].name + " has the highest grade: " + studLst[0].grade);

        var resulty = from x in studLst
                      where x.grade < 50 select x;

        System.Console.WriteLine("(ex 1.) Candidates that can not be enrolled (too few scores):");


    }
}
}