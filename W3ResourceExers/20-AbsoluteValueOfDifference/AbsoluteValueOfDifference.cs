using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_AbsoluteValueOfDifference
{
    class AbsoluteValueOfDifference
    {
        //20. Write a C# program to get the absolute value 
        //of the difference between two given numbers. 
        //Return double the absolute value of the difference if
        //the first number is greater than second number. Go to the editor

        static void Main(string[] args)
        {
            double firstNumber=default(double);
            double secondNumber=default(double);

            Console.WriteLine("Type the first number");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type the second number");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            var theDiference = firstNumber - secondNumber;
         

            if (theDiference<0)
            {
                Console.WriteLine("The absolute value: {0}", Math.Abs(theDiference));
            }
            else if(firstNumber>secondNumber)
            {
                Console.WriteLine("Double of the absolute value: {0}", Math.Abs(theDiference) * 2);
            }
            Console.ReadLine();


        }
    }
}
