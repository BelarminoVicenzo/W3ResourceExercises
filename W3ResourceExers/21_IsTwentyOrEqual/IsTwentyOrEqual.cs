using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_IsTwentyOrEqual
{
    class IsTwentyOrEqual
    {


        //21. Write a C# program to check the sum of the two given integers 
        //and return true if one of the integer is 20 or if their sum is 20. 
        //Go to the editor
        //Click me to see the solution
        static void Main(string[] args)
        {
            //sorry to copy, but... Repeating all this
            //first namuber and stuff all the time?
            //CTRL+C/V...

            double firstNumber = default(double);
            double secondNumber = default(double);

            Console.WriteLine("Type the first number");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type the second number");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            bool isTwenty = false;

            if ((firstNumber+secondNumber)==20 || firstNumber==20 || secondNumber==20)
            {
                isTwenty = true;
            }
            Console.WriteLine("Result: "+isTwenty);


            Console.ReadKey();
        }
    }
}
