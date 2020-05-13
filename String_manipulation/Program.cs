using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exersice 6 : String manipulation!");
            // A program that asks the user for a string and:
            //-Replaces all spaces with underscores(storing the result in a new string)
            //- Removes leading spaces(storing the result in another string)
            //- Removes trailing spaces(storing the result in another string)
            //- Replaces all lowercase A by uppercase A(storing the result in another string)
            //The program must display all the strings it generates.

            Console.WriteLine("Please Enter a string!");
            string str = Console.ReadLine();

            Console.WriteLine("User input string :" + str);

            string strSpace = str.Replace(" ", "_");
            Console.WriteLine("string with underscores :" + strSpace);

            string strLspace = str.TrimStart();
            Console.WriteLine("string without leading spaces :" + strLspace);

            string strTspace = str.TrimEnd();
            Console.WriteLine("string without trailing spaces :" + strTspace);

            string strCase = str.Replace('a','A');
            Console.WriteLine("string with lowercase A by uppercase A :" + strCase);




            Console.ReadKey();

        }
    }
}
