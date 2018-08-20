using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_MultiplicationTable
{
    class MultiplicationTable
    {
        /*
         
    8. Write a C# Sharp program that takes a number
    as input and print its multiplication table 
    
            Test Data:
    Enter the number: 5
    Expected Output:
    5 * 0 = 0
    5 * 1 = 5
    5 * 2 = 10
    5 * 3 = 15
    ....
    5 * 10 = 50*/

        static void Main(string[] args)
        {
            double number = 0;

            int counter = 0;
            // I will only make form 0 to 12
            //I know I can make more, but to make the output small I won't use more than 12

            Console.WriteLine("Please insert a number ");

            number = double.Parse(Console.ReadLine());
            Console.WriteLine("The number is: " + number);
            do
            {
                //I didn't wanted to use concatenation, but I'm
                //not that good with string interpolation
                Console.WriteLine($"{number + "*" + counter} = {(number * counter)}");
                counter++;
            } while (counter < 13);

        }
    }
}
