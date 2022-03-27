using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSet
{
    public static class SimpleInterest
    {
        public static void FindSI()
        {
            double principal, rate, time, interest;
            Console.WriteLine("Enter Principal amount(Rs): ");
            principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate: ");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time/year: ");
            time = Convert.ToDouble(Console.ReadLine());

            interest = principal * rate * time / 100;
            Console.WriteLine("Simple interest of given ammount " + principal + "Rs. at rate of " + rate + "% in " + time + "year(s) is: " + interest + "Rs");
        }
        
    }
}
