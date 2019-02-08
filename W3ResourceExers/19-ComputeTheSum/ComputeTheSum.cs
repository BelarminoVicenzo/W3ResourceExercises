using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ComputeTheSum
{
    class ComputeTheSum
    {

        //19. Write a C# program to compute the sum of two given integers,
        //if two values are equal then return the triple of their sum.
        //Go to the editor
        static void Main(string[] args)
        {
            int firstInteger = default(int);
            int secondInteger = default(int);

            Console.WriteLine("Type the first Integer");
            firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the second Integer");
            secondInteger = Convert.ToInt32(Console.ReadLine());

            if (firstInteger != secondInteger)
            {
                Console.WriteLine("Result: {0}", (secondInteger + firstInteger));
            }
            else
            {
                Console.WriteLine("Tripled result: {0}", (secondInteger + firstInteger) * 3);
            }
            Console.ReadLine();
        }

    }
}

