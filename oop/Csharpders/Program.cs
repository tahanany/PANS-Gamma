using System.Reflection.Metadata;
namespace Csharpders
{
    public class Employee
    {

        public string name;
        public string position;
        public double salary;
        public int age;
        static int getNum()
        {

            Random random = new Random();
            //int age = random.Next(1, 100);
            int age = 1111111111;
            return age;

        }


        public Employee(string nm, string pt, double sl)
        {
            name = nm;
            position = pt;
            salary = sl;
            age = getNum();
            
        }
    }

    internal class Program
    {
       

        static void Main(string[] args)
        {
            

            Employee employee1 = new("Taha", "Computer blabla", 150);
            Employee employee2 = new("Emir ", "Military", 8888888);

            Console.WriteLine(employee1.name+" "+employee1.age);
            Console.WriteLine(employee2.salary);
        }

    }
}
