using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ThreeNumbersInput
{
    class ThreeNumbersInput
    {

        /*
        
            10. Write a C# Sharp program to that takes three numbers(x,y,z) 
        as input and print the output of (x+y).z and x.y + y.z

        Test Data:
        Enter first number - x
        Enter second number - y
        Enter third number - z

        Expected Output:
        Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72

        */




        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Write 3 numbers\n");

            Console.Write("#1: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("#2: ");
            y = double.Parse(Console.ReadLine());


            Console.Write("#3: ");
            z = double.Parse(Console.ReadLine());

            Console.WriteLine($"({x}+{y}).{z}={(x + y) * z}");
            Console.WriteLine($"({x}.{y})+({y}.{z})= {(x * y) + (y * z)}");
        }
    }
}
