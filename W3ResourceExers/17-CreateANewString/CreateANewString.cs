using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CreateANewString
{
    class CreateANewString
    {
        //17. Write a C# program to create a new string from a given string 
        //(length 1 or more ) with the first character added at the front and back. Go to the editor
        //Sample Output:
        //Input a string : The quick brown fox jumps over the lazy dog.
        //TThe quick brown fox jumps over the lazy dog.T
        static void Main(string[] args)
        {
            

            string defaultString = "ead Man Wonderlan";
            Console.WriteLine("Type a string (always type d)");
            string givenString = Console.ReadLine();
            var newString = givenString + defaultString + givenString;

            Console.WriteLine(newString);

            Console.ReadKey();

        }


    }
}
