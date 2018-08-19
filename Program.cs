using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The factorial numbers from 1-10 are:");
            for(int i=1;i<= 10; ++i)
            {
                int number = i;
                Console.WriteLine("The number is {0} and it's factorial is {1}", number, Factorial(number));
                

            }
            Console.ReadKey(true);
            
        }
        static int Factorial(int n)
        {
            return Enumerable.Range(1, n).Aggregate((i, r) => r * i);
        }
    }
}
