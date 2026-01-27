using System;

class Program
{
    static void Main()
    {
        Console.Write(" ");
        string n = (Console.ReadLine());
        int ni = Convert.ToInt32(n);

        int a = 0;
        int b = 1;

        Console.WriteLine("Fibonacci:");

        for (int i = 1; i <= ni; i++)
        {
            Console.Write(a + " ");
            (a, b) = (b, a + b);
        }

        Console.WriteLine();
    }
}
