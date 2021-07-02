using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingProgram
{
    class TemperatureConversion
    {
        public static void ReadInput()
        {
            Console.WriteLine("Choose Conversion ");
            Console.WriteLine("1.Celsius to Fahrenheit\n2.Fahrenheit to Celsius");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter degree in celsius ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    TemperatureChange("celsius",celsius);
                    break;
                case 2:
                    Console.WriteLine("Enter degree in Fahrenheit ");
                    double Fahrenheit = Convert.ToDouble(Console.ReadLine());
                    TemperatureChange("Fahrenheit", Fahrenheit);
                    break;
            }

        }

        private static void TemperatureChange(string degree_Type,double degree)
        {
            double result = (degree_Type.Equals("celsius") ? degree * 9 / 5 + 32 : (degree - 32) * 5 / 9);
            Console.WriteLine(degree_Type.Equals("celsius")?$"{degree}`C is {result}`F": $"{degree}`F is {result}`C");
        }
        
    }
}
