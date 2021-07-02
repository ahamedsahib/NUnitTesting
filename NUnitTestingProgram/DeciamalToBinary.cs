using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingProgram
{
    class DeciamalToBinary
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the number to get Binay Form ");
            int num = Convert.ToInt32( Console.ReadLine());
            FindBinary(num);
        }
        private static void FindBinary(int num)
        {
            int i;
            int[] a = new int[10];//initalizing array to store values  
            for ( i = 0; num > 0; i++)
            {
                a[i] = num % 2;//store the binary value
                num = num / 2;
            }

            Console.Write($"Binary of the given number {num} ");
            for ( i = i - 1; i >= 0; i--) //i previous value 4 it iterates till reach the first index
            {
                Console.Write(a[i]);
            }
        }
    }
}
