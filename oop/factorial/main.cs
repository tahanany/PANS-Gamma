using System;
class HelloWorld {
    
    
  static long factorial(int n)
  {
    
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        
        result = result*i;
        
    }
    return result;
    
  }
  
  static long factorial2(int n)
  {
    int result = 1;
    int i = 1;
    while (i <= n)
    {
        
        result = result*n;
        n--;
        
    }
    return result;
    
  }
    
    
    static void Main() {
      Console.WriteLine("5! = " + factorial(5));
      Console.WriteLine("5! = " + factorial2(5));  
        
    }
    
    
  
}