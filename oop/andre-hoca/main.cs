/******************************************************************************

lesson01.cs
Calculating number pi according to leibniz

*******************************************************************************/
// using System;
// class numberPiLeibnitz {
//   static void Main() 
//   {
   
//     int pi = 0;

//     for (int i = 1; i <= 10; i++)
//     {
        
//         if(i%2 == 1) {
//         Console.Write(i+" ");
//         }
        
//         else{
//         Console.Write((i-2*i)+" ");
            
//         }
//         }
        
        
//     }

//   }

// using System;
// class numberPiLeibnitz {
//   static void Main() 
//   {
//       double total = 0;
//     double RealPi = 3.141592;
//     int pi = 0;
//     int k = 1;
//     int num = 1000000;
//     for (int i = 1; i <= num; i+=2)
//     {
//         // Console.Write(1.0/(k*i)+", ");
//         total += 1.0/(k*i);
//         k = k*(-1);
        
//     }
//     Console.WriteLine("pi =" + 4*total);
//     Console.WriteLine("diff =" + (4*total-RealPi));
    
//   }

// using System;
// class numberPiLeibniz {
//   static void Main() 
//   {
   
//     int k = 1;
//     double pi=0;
//     int iter=1000000;
//     double realPi=3.141592;
//     /*for (int i = 1; i <= 10; i+=2)
//     {
//         if(i%2==0)
//         {
//             Console.Write(i-(i*2)+" ");
//         }
    
//         else
//         {
//             Console.Write(i+" ");
//         }
//     }*/
    
    
//     for (int i = 1; i <= iter; i+=2)
//     {
//         //Console.Write(1.0/(k*i)+" ");
//         pi += 1.0/(k*i);
//         k=k*(-1);
//     }
    
//     double OurPi=pi*4;
//     Console.WriteLine("pi:"+OurPi);
//     double diff=OurPi-realPi;
//     Console.WriteLine("diff =" + Math.Round(diff,10));
    
    
//     Console.WriteLine("pi="+ Math.Round(4*pi,4));


//   }
// }
  
  
// }

// using System;

// class NumberPiLeibnitz   {
//     static void Main() {


//         string a ;

//         a = Console.ReadLine();
//         int b = Convert.ToInt32(a);
//         if (b <= 0)
//         {

//             Console.WriteLine(b * -1);
//         }

//         else {

//             Console.WriteLine(a);
//         }
    
//     }

// }

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
            
            OurPi = NumberPiEuler(100");
            Console.WriteLine("pi acc to Euler = " + OurPi);
            diff = OurPi - RealPi;
            Console.WriteLine("Diff = " + Math.Abs(Math.Round(diff,10))); //
        }
    }





