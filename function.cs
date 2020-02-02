using System;

namespace ConsoleApp6
{
    class function
    {
        static void Main(string[] args)
        {
                int a, b, c;
                

                Console.WriteLine("Please enter value of a:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter value of b:");
                b = Convert.ToInt32(Console.ReadLine());

                Func<int, int, int> funcAdd = (a, b) => a + b;
                c = funcAdd.Invoke(a, b);
                Console.WriteLine(Convert.ToString(c));//Returns addition of two numbers entered by the user
               Console.ReadLine();

            
        }
    }
}
