using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListOfProgram
{
    public static class WordExtention
    {
        public static int MyExtention(this string str )
        {
            if(string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }


            // Split the string into words based on spaces and punctuation
            var words = str.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ';', ':', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static int wordcount(this String value)
        {
            var count = value.Split(' ').Count();// it will split the word with ' ' and count 
            return count;

        }
    }
}
