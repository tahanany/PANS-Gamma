using System.Reflection.Metadata;
using System.Xml.Linq;
namespace Csharpders
{
    public class Employee
    {

        private string name;
        private string position;
        private double salary;
        private int age;

        public string isim
        {
            get { return name; }
            set { name = value; }
        }

        public string pozisyon
        {
            get { return position; }
            set { position = value; }
        }

        public double maas
        {
            get { return salary; }
            set { salary = value; }
        }
        public int yas
        {
            get { return age; }
            set { age = value; }
        }



        static int getNum()
        {

            Random random = new Random();
            int age = random.Next(1, 100);
            
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
            List<Employee> employees = new List<Employee>();
            int NumOfEmployees = 5;

            for (int i = 0; i < NumOfEmployees; i++)
            {
                
                Employee employee = new Employee ("employee"+i.ToString (),"Position"+i.ToString(),10000);

            }                

            Employee employee1 = new("Taha", "Computer blabla", 150);
            Employee employee2 = new("Emir ","Military", 80000);

            Console.WriteLine("Name: {0} Position:{1} Salary:{2} Age:{3}",employee1.isim, employee1.pozisyon, employee1.maas, employee1.yas);
            Console.WriteLine(employee2.maas);
        }

    }
}
