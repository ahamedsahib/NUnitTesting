using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingProgram
{
    class MonthlyPayment
    {
        public static void ReadInput()
        {

            Console.WriteLine("Enter the Principle amount");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of years");
            double years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the rate of interest");
            double rateOfInterest = Convert.ToDouble(Console.ReadLine());


            FindMonthlyPayment(principle, years, rateOfInterest);

        }
        private static void FindMonthlyPayment(double p, double y, double rate)
        {
            double payment = 0;
            double n, r,res;

            n = 12 * y;
            r = rate / (12 * 100);
            res =  Math.Pow(1 + r, n);
            payment = p * r *res/(res-1);

            Console.WriteLine($"Monthly Paymnet ={Math.Round(payment,2)}");
        }
        
    }
}
