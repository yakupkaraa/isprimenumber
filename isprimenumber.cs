using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isitprimenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (IsPrimeNumber(140))
            {
                Console.WriteLine("this is a prime number");

            }
            else
            {
                Console.WriteLine("this is not a prime number");
            }
            Console.ReadLine();


        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }

            }
            return result;
        }
    }
}