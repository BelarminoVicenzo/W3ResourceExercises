using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AgeULookOlder
{
    class AgeULookOlder
    {

        // 11. Write a C# Sharp program that takes an age (for example 20) 
        // as input and prints something as "You look older than 20". 
        // Test Data:
        // Enter your age - 25
        // Expected Output:
        // You look older than 25


        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());

            
            Console.WriteLine($"You look older than {age}");
        }
    }
}
