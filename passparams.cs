
using System;

namespace helloworld
{
    class square
    {
        static void calcsquare(int x,int y)
        {
            x = x * x;
            y = y * y;
            Console.WriteLine(x + "\t" + y);
        }  
       
        
      static void Main(string[] args)
        {
            int a = 10;
            int b = 10;

            Console.WriteLine(a + "\t" + b);
            calcsquare(a, b);
            Console.WriteLine(a + "\t" + b);
            Console.ReadLine();


        }
    }
}
