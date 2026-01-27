using System;
using System.Collections.Generic; // List<T> için
using System.Linq; // LINQ için

namespace AnimalApp
{
    public class Animals
    {
        private string _name = "";
        private string _breed = "";
        private double _cost;

        public string Name { get; set; }
        public string Breed { get; set; }
        public double Cost { get; set; }

        public double HowMuch()
        {
            double walkingFee = 50.00;
            if (Breed.ToLower() == "dog")
                return Cost + walkingFee;
            else
                return Cost;
        }
    }

    class Program
    {
        static void Main()
        {
            // Hayvanları bir listeye ekliyoruz
            List<Animals> animals = new List<Animals>
            {
                new Animals { Name = "Leo", Breed = "Dog", Cost = 300.00 },
                new Animals { Name = "Molly", Breed = "Cat", Cost = 300.00 },
                new Animals { Name = "Casey", Breed = "Cat", Cost = 300.00 },
                new Animals { Name = "Gorlock", Breed = "Dog", Cost = 300.00 }
            };

            // Her hayvanın toplam maliyetini yazdır
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}, Breed: {animal.Breed}, Total Cost = ${animal.HowMuch()}");
            }

            // LINQ ile ortalama toplam maliyeti hesapla
            double averageCost = animals.Average(a => a.HowMuch());

            Console.WriteLine($"\nAverage total cost of animals: ${averageCost}");
        }
    }
}
