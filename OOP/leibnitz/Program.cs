using System;
class numberPiLeibnitz {
  static void Main() 
  {
      double total = 0;
    double RealPi = 3.141592;
    int pi = 0;
    int k = 1;
    int num = 1000000;
    for (int i = 1; i <= num; i+=2)
    {
        // Console.Write(1.0/(k*i)+", ");
        total += 1.0/(k*i);
        k = k*(-1);
        
    }
    Console.WriteLine("pi =" + 4*total);
    Console.WriteLine("diff =" + (4*total-RealPi));
    
  }
}
