using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_TemperatureConverter
{
    internal class TemperatureConverter
    {

        //14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. Go to the editor
        //Test Data:
        //Enter the amount of celsius: 30
        //Expected Output:
        //Kelvin = 303
        //Fahrenheit = 86
        private static void Main(string[] args)
        {
            float celsius = default(float);
            float fahrenheit = default(float);
            float kelvin = default(float);

            //celsius, 0,32 fahrenheit, 273.1 kelvin
            //celsius 1, 33.8 fahrenheit, 274.1 kelvin
            //celsius 2, 35.6 fahrenheit, 275.1 kelvin

            //F=c°×9/5+32
            //K=c*1+273.1


            Console.WriteLine("Write a temperature, notice that this temperature will have\n" +
                "the default Temperature of Celsius\n");
            celsius = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();
            fahrenheit = celsius == 0 ? default(float) : Convert.ToSingle((celsius * 1.8) + 32);
            kelvin = celsius == 0 ? default(float) : Convert.ToSingle((celsius * 1) + 273.1);

            Console.WriteLine($"Temperature is in Celsius: {celsius} C°");
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit} F°");
            Console.WriteLine($"Temperature in Kelvin: {kelvin} K°");
        }
    }
}
