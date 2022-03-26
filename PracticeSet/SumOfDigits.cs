using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSet
{
    public static class SumOfDigits
    {
        public static void FindSum()
        {
            int number, sum = 0, remainder;
            Console.WriteLine("Enter a Number");
            number = Convert.ToInt32(Console.ReadLine());
            while(number >0)
            {
                remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
            }
            Console.WriteLine("Sum of digits=" + sum);
        }
    }
}
