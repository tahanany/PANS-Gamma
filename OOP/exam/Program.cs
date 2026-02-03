using System;
using System.Collections.Generic;
using System.Linq;

class Figure
{
    public int Dimension; // Şeklin boyutunu tutar

    public Figure(int dimension)
    {
        Dimension = dimension;
    }

    public virtual double GetArea()
    {
        return 0; 
    }
}

// Rectangle Alt sınıfı figurenin
class Rectangle : Figure
{
    public double Width;
    public double Length;

    // boylarını ölç
    public Rectangle(double width, double length) : base(2)
    {
        Width = width;
        Length = length;
    }

    // area = genişlik x uzunluk
    public override double GetArea()
    {
        return Width * Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Rectangle> rectangles = new List<Rectangle>();
        rectangles.Add(new Rectangle(54, 3.5));
        rectangles.Add(new Rectangle(34, 6));
        rectangles.Add(new Rectangle(67.8, 6));

        foreach (var rect in rectangles)
        {
            Console.WriteLine("Rectangle: Width = " + rect.Width + ", Lnegth = " + rect.Length + ", Area = " + rect.GetArea());
        }

        // AVG AREA HESAPLA
        double averageArea = rectangles.Average(r => r.GetArea());
        Console.WriteLine("\nAverage area of rectangles: " + averageArea);
    }
}
