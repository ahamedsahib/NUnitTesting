using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingProgram
{
    class SwapNibbles
    {
        public static void ReadInput()
        {
            int number;
            Console.WriteLine("Enter the value of Decimal number");
            number = Convert.ToInt32(Console.ReadLine());

            BinaryForm(number);

        }

        
        private static void BinaryForm(int number)
        {
            // swap nibbles using left shift 4 & and Right shift 4 using Bitwise Operator and Perform OR operation
            int swapped_Number = ((number & 0x0F) << 4 | (number & 0xF0) >> 4);

            Console.WriteLine($"The Decimal number after swapped = {swapped_Number}");
            //calling is IsPowerOfTwo() to check power of 2 by ysing Conditional Operator
            Console.WriteLine((IsPowerOfTwo(swapped_Number))?$"{swapped_Number} is power of 2":$"{swapped_Number} not power of 2");
        }
         private static  bool IsPowerOfTwo(int x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);//to check power of 2
        }


    }
}