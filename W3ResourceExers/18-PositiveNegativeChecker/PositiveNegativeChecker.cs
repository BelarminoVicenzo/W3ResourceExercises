using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_PositiveNegativeChecker
{
    class PositiveNegativeChecker
    {

        //18. Write a C# program to check two given integers and return true if one is negative and one is positive. Go to the editor
        //Sample Output:
        //Input first integer:
        //-5
        //Input second integer:
        //25
        //Check if one is negative and one is positive:
        //True
        static void Main(string[] args)
        {
            int firstInteger = default(int);
            int secondInteger = default(int);

            Console.WriteLine("Type the first Integer");
            firstInteger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the second Integer");
            secondInteger = Convert.ToInt32(Console.ReadLine());



            //if one of them is positive, he will be 0 or bigger than 0
            if (firstInteger >= 0 && secondInteger >= 0)
            {
                Console.WriteLine("false");
            }
            //if one of them is negative, he will be smaller than zero
            else if (firstInteger < 0 && secondInteger > 0 || firstInteger > 0 && secondInteger < 0)
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("IDK");
            }

            Console.ReadLine();
        }

    }
}
