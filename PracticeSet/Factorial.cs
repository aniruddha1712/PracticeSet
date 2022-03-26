using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSet
{
    public static class Factorial
    {
        public static void FindFactorial()
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter any number:");
            number = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + " is: " + fact);
        }
    }
}
