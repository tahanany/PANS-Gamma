using System;
class NumberPi {
    
    static double NumberPiLeibnitz(int num)
    {
        
        double total = 0;
        int k = 1;
        for (int i=1; i<=num; i+=2)
        {
            total += 1.0/(k*i);
            k = k*(-1); // changing the signs +- +- +-
        }
        return(4*total);
        }
        
        static double NumberPiEuler(int num)
        {
         double total = 0;   
            for (int i=1; i<=num; i++)
        {
            total += 1.0/(i*i);
        }
             return Math.Sqrt(6.0 * total);
        }
        
        
        static void Main() {
            double RealPi = 3.141592;
            double OurPi = NumberPiLeibnitz(100);
            Console.WriteLine("pi acc to Leibnitz = " + OurPi);
            double diff = OurPi - RealPi;
            Console.WriteLine("Diff = " + Math.Abs(Math.Round(diff,10)));
            
            OurPi = NumberPiEuler(100);
            Console.WriteLine("pi acc to Euler = " + OurPi);
            diff = OurPi - RealPi;
            Console.WriteLine("Diff = " + Math.Abs(Math.Round(diff,10))); //
        }
    }