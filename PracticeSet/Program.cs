﻿using System;
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
            Console.WriteLine("1:FindPrime\n2:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrimeNumber.FindPrime();
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
