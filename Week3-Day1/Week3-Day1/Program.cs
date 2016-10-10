using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string to use in the program
            string myString = "The quick brown fox jumped over the lazy dog";

            //Call the extension method (string was extended)
            int wordCount = myString.WordCount();

            //Write things out to check our work
            Console.WriteLine("The number of words in your string is {0}", wordCount);
            Console.WriteLine("{0}", myString.RemoveSpaces());
            Console.ReadKey();
        }
    }

    //Class to hold our extension methods
    public static class Utils
    {
        //Create an extension on string
        public static int WordCount(this String stringToCount)
        {
            int count = 0;

            for(int i = 0; i < stringToCount.Length; i++)
            {
                if (stringToCount[i].ToString() == " ")
                    count++;
            }

            return count;
        }

        //This method extends string again
        public static string RemoveSpaces(this string stringWithSpaces)
        {
            string stringWithoutSpaces;
            stringWithoutSpaces = stringWithSpaces.Replace(" ", "");
            return stringWithoutSpaces;
        }
    }
}
