using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoops
{
    public static class WordCountClass
    {
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

    public class DoesSomething
    {
        public bool IsSomethingCool()
        {
            return true;
        }
    }

    public static class DoesSomethingElse
    {
        public static bool IsSomethingCool()
        {
            return false;
        }
    }
}
