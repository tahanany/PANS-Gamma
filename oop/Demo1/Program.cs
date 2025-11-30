//The concepts of OOP in C#
using System;
namespace OOP_in_Csharp
{
    public class Computer
    {
        private string _BIOSname;
        private string _ipadress;
        private string _OS;

        public Computer(string bn, string ip, string os)
        {
            _BIOSname = bn;
            _ipadress = ip;
            _OS = os;
        }

        public string BiosName
        {
            get { return _BIOSname; }
            set { _BIOSname = value; }
        }

        public string IpAdress
        {
            get { return _ipadress; }
            set { _ipadress = value; }
        }

        public string OS
        {
            get { return _OS; }
            set { _OS = value; }
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Computer[] net = new Computer[4];

            for (int i = 0; i < net.Length; i++)
            {
                net[i] =
                  new Computer("comp" + i.ToString(),
                        "10.0.20" + i.ToString(), "win10");
            }

            for (int i = 0; i < net.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", net[i].BiosName, net[i].IpAdress, net[i].OS);
            }
        }
    }
}

/*

          

           */

/*
  static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(1, 255);
            return num.ToString();
        }
 
 
 */