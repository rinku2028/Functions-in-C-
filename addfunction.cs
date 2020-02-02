using System;

namespace addfunction
{
    class addfunction
    {
        public static int sum(int x,int y)
        {
            int z = x + y;
            return z;
        }
        public static int mul(int x,int y)
        {
            int z = x * y;
            return z;
        }

        public static int div(int x,int y)
        {
            int z = x / y;
            return z;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of two numbers:"+ "\t" + sum(10, 10));
            Console.WriteLine("Multiplication of two numbers:" + "\t" + mul(10, 10));
            Console.WriteLine("Result of two numbers divide:" + "\t" + div(10, 10));
            Console.ReadLine();

        }
    }
}
