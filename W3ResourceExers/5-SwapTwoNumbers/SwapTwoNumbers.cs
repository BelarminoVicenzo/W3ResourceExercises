using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_SwapTwoNumbers
{
    class SwapTwoNumbers
    {
        /*

       5. Write a C# Sharp program to swap two numbers.  
         Test Data:
         Input the First Number : 5
         Input the Second Number : 6
         Expected Output:
         After Swapping :
         First Number : 6
         Second Number : 5 
                  */
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            Console.WriteLine("Input the First Number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the Second Number");
            secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First Number: {1}\n" +
                "Second Number: {0}", firstNumber, secondNumber);
        }
    }
}
