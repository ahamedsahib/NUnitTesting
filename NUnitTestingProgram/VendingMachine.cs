using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingProgram
{
    class VendingMachine
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the amount you want to Change for");
            int amount = Convert.ToInt32(Console.ReadLine());
            ChangingProcess(amount);
        }
        private static void ChangingProcess(int amount)
        {
            Console.WriteLine($"The Change for the amount Rs{amount} is");
            int[] rupessArray = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] change = new int[rupessArray.Length];
            for (int i = 0; i < rupessArray.Length ; i++)
            {
                if (amount >= rupessArray[i])//to check amount greater than rupee we can change
                {
                    change[i] = amount / rupessArray[i];//to get how many notes can make the amount 
                    amount -= (change[i] * rupessArray[i]);//finding remaining notes for change
                }
            }
            
            for (int i = 0; i < rupessArray.Length ; i++)
            {
                if (change[i] != 0)//used to print the change that are available 
                {
                    Console.WriteLine($"{change[i]} * {rupessArray[i]}   = Rs"+(change[i]*rupessArray[i]));
                }
            }



        }
    }
}
