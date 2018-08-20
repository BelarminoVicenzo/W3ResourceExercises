using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Average
{
    class Average
    {
        /*
        
            9. Write a C# Sharp program that takes four numbers as 
            input to calculate and print the average
            
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the third number: 20
            Enter the four number: 30

            Expected Output:
            The average of 10 , 15 , 20 , 30 is: 18

            */
        static void Main(string[] args)
        {
            //I could use an array, but I don't want to
            int number = 0;

            Console.WriteLine("Please write four numbers");

            for (int i = 1; i < 5; i++)
            {
                number += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The average is: {(number/4)}");
        }
    }
}
