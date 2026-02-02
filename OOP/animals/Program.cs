using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalApp
{
    public class Animal
    {
        private string _name;
        private double _cost;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public double HowMuch()
        {
            return Cost;
        }
    }

    public class Dog : Animal
    {
        public double HowMuch()
        {
            double walkingFee = 50.0;
            return Cost + walkingFee;
        }
    }

    public class Cat : Animal
    {
        public double HowMuch()
        {
            return Cost;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog { Name = "Leo", Cost = 300 },
                new Cat { Name = "Molly", Cost = 300 },
                new Cat { Name = "Casey", Cost = 300 },
                new Dog { Name = "Gorlock", Cost = 300 }
            };

            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    Dog d = (Dog)animal;
                    Console.WriteLine($"{d.Name} total cost: {d.HowMuch()}");
                }
                else if (animal is Cat)
                {
                    Cat c = (Cat)animal;
                    Console.WriteLine($"{c.Name} total cost: {c.HowMuch()}");
                }
            }

            double dogAverage = animals
                .Where(a => a is Dog)
                .Cast<Dog>()
                .Average(d => d.HowMuch());

            double catAverage = animals
                .Where(a => a is Cat)
                .Cast<Cat>()
                .Average(c => c.HowMuch());

            Console.WriteLine("\nAverage Dog Cost: " + dogAverage);
            Console.WriteLine("Average Cat Cost: " + catAverage);
        }
    }
}
