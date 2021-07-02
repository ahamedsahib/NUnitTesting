using System;

namespace NUnitTestingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To NUnit Testing Programs");
            Console.WriteLine("Choose the Program you want to run");
            Console.WriteLine("1)Vending Machine\n2)DayofWeek\n3)TemperartureConversion\n4)MonthlyPayment\n5)SquareRoot\n6)Exit");

            Console.WriteLine("Enter The option");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    VendingMachine.ReadInput();
                    break;
                case 2:
                    DayofWeek.ReadInput();
                    break;
                case 3:
                    TemperatureConversion.ReadInput();
                    break;
                case 4:
                    MonthlyPayment.ReadInput();
                    break;
                case 5:
                    SquareRoot.ReadInput();
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;
            }
        }
    }
}
