using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MultiplicationOfTwoNumbers
{

    // 6 and 7 will be solved in this solution


    /*
    6. Write a C# Sharp program to print the output of multiplication
    of three numbers which will be entered by the user.
    Test Data:
    1st: x
    2nd: y
    3rd: z
    Expected Output:
    x * y * z = xyz


    7. Write a C# Sharp program to print on screen the output of adding,
    subtracting, multiplying and dividing of two numbers which will be
    entered by the user. 
    Test Data:
    1st: x
    2nd: y
    Expected Output:
    x + y = 29
    x - y = 21
    x x y = 100
    x / y = 6
    x mod y = 1

 */
    class MultiplicationOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            Console.WriteLine("Please enter 3 numbers\n");

            Console.Write("#1: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("#2: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("#3: ");
            number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Answer for 6. \n\n" +
                "{0}x{1}x{2}=({3})", number1, number2, number3, (number1 * number2 * number3));

            // 7.
            // I«m going to use number1 and number2
            Console.WriteLine("-----------------------\n\n");

            //    x mod y = 1
            Console.WriteLine("Answers for 7.\n");
            Console.WriteLine("{0} + {1}={2}\n", number1, number2, (number1 + number2));
            Console.WriteLine("{0} - {1}={2}\n", number1, number2, (number1 - number2));
            Console.WriteLine("{0} x {1}={2}\n", number1, number2, (number1 * number2));
            Console.WriteLine("{0} / {1}={2}\n", number1, number2, (number1 / number2));
            Console.WriteLine("{0} % {1}={2}\n", number1, number2, (number1 % number2));



        }
    }
}
