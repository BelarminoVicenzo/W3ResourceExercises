using System;

namespace _13_Rectangle
{
    internal class Rectangle
    {

        // 13. Write a C# program that takes a number as input and 
        // then displays a rectangle of 3 columns wide and 5 rows 
        // tall using that digit. Go to the editor
        // Test Data:
        // Enter a number: 5
        // Expected Output:
        // 555
        // 5 5
        // 5 5
        // 5 5
        // 555
        private static void Main(string[] args)
        {

            int number = default(int);

            Console.WriteLine("Please enter a integer number");
            number = Convert.ToInt32(Console.ReadLine());



            Console.Write("{0}{0}{0}", number);
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} {0}",number);
            }
            Console.Write("{0}{0}{0}", number);


            Console.ReadLine();

        }
    }
}
