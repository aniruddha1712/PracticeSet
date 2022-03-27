using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PracticeSet");
            Console.WriteLine("1:FindPrime\n2:Factorial\n3:FindSumOfDigits\n4:FibonacciSeries\n5:FindSimpleInterest");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrimeNumber.FindPrime();
                    break;
                case 2:
                    Factorial.FindFactorial();
                    break;
                case 3:
                    SumOfDigits.FindSum();
                    break;
                case 4:
                    Fibonacci.FibonacciSeries();
                    break;
                case 5:
                    SimpleInterest.FindSI();
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
