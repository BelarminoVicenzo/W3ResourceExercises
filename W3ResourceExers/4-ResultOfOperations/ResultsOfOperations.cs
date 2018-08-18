using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ResultOfOperations
{
    class ResultsOfOperations
    {

        // 4. Write a C# Sharp program to print the result of the specified operations

        /*
         Test data:

          -1 + 4 * 6
          ( 35+ 5 ) % 7
          14 + -4 * 6 / 11
          2 + 15 / 6 * 1 - 7 % 2
      

      Expected Output:
        23,5,12,3

     */

         
        static void Main(string[] args)
        {

            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + (-4) * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            



        }
    }
}
