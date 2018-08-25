using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_FourTimesInARow
{
    class FourTimesInARow
    {

        // 12. Write a C# program to that takes a number as input and display
        // it four times in a row (separated by blank spaces), and then four 
        // times in the next row, with no separation. You should do it two times:


        //Test Data:
        //Enter a digit: 25
        //Expected Output:
        //25 25 25 25
        //25252525
        //25 25 25 25
        //25252525



        // it will return a string with the spaces
        static string WithSpaces(double number)
        {
            string displayTogether = "";
            for (int i = 0; i < 4; i++)
            {
                displayTogether += $"{number} ".ToString();
            }

            return displayTogether;
        }


        // it will return a string without the spaces
        static string WithoutSpaces(double number)
        {
            string displayWithout = "";
            for (int i = 0; i < 4; i++)
            {
                displayWithout += $"{number}".ToString();
            }

            return displayWithout;
        }

        static void Main(string[] args)
        {

            double number = 0;
            Console.WriteLine("Please input a number");
            number = double.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(WithSpaces(number));
                Console.WriteLine(WithoutSpaces(number));

            }
            Console.WriteLine();
        }
    }
}
