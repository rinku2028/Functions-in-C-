
using System;

namespace function
{
    class function
    {
        public static int add(int num1,int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of two numbers:" + "\t" + add(x, y));
            Console.ReadLine();


        }


    }
}
