using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoops
{
    public static class WordCountClass
    {
        //Create a methods that extends (adds to) the string class
        public static int CountWords(this string originalString)
        {
            int count = 0;

            foreach(char c in originalString)
            {
                if (c == ' ')
                    count++;
            }
            count++;

            return count;
        }
    }

    //Create a regular method
    public class DoesSomething
    {
        public bool IsSomethingCool()
        {
            return true;
        }
    }

    //Create another regular method 
    public static class DoesSomethingElse
    {
        public static bool IsSomethingCool()
        {
            return false;
        }
    }
}
