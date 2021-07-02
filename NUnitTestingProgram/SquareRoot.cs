using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingProgram
{
    class SquareRoot
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the number to find Square root of it");
            int num = Convert.ToInt32(Console.ReadLine());
            FindSquareRoot(num);
        }
        private static void FindSquareRoot(int c)
        {
            double t = c;//to store the value of num without changing original value
            double l = 0.00001;
            double root;

            while (true)
            {

                root = 0.5 * (t + (c / t));

                if (Math.Abs(root - t) < l)
                {
                    break;
                }

                t = root;

            }
            Console.WriteLine($"The square root of {c}is {root}");

        }
    }
}
