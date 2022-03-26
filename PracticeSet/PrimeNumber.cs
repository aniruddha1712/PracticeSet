using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSet
{
    public static class PrimeNumber
    {
        public static void FindPrime()
        {
            int n, i, m = 0, flag = 0;
            Console.WriteLine("Enter number to check if it is prime");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for (i = 2; i<=m; i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine("Number is not Prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime");
        }
    }
}
