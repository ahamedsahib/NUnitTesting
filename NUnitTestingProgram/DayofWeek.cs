using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingProgram
{
    class DayofWeek
    {
        public static void ReadInput()
        {
            
            Console.WriteLine("Enter the date form 1-31");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Month MM from 01-12");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year in YYYY format");
            int year = Convert.ToInt32(Console.ReadLine());

            FindDayOfWeek(date, month, year);


        }
        private static void FindDayOfWeek(int d, int m, int y)
        {
            
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //calculating day of week using georgian formula
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            
            Console.WriteLine($"The Day on {d}/{m}/{y}  is {daysOfWeek[d0]} ");
        }

    }
}
