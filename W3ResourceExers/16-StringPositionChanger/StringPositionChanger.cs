﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_StringPositionChanger
{
    class StringPositionChanger
    {

        // 16. Write a C# program to create a new string from a given string where the first
        //and last characters will change their positions. Go to the editor
        //Test Data:
        //w3resource
        //Python
        //Sample Output:
        //e3resourcw
        //nythoP
        //x
        static void Main(string[] args)
        {

            string oldString = "ene PiecO";
            StringBuilder builder = new StringBuilder();

            builder.Append(oldString.Substring(oldString.Length-1, 1));
            builder.Append(oldString.Substring(1, oldString.Length - 2));
            builder.Append(oldString.Substring(0,1));

            Console.WriteLine("Old one: {0}",oldString);
            Console.WriteLine();
            Console.WriteLine("New string: {0}",builder.ToString());
            Console.ReadKey();

        }
    }
}
