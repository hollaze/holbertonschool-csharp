using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// String class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// determines how many words are in a string.
        /// Each word begins with a capital letter except the first word.
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>number of words in string s</returns>
        public static int CamelCase(string s)
        {
            int numberOfWord = 1;

            if (s == null || s.Length == 0)
                return (0);

            for (int i = 1; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                    numberOfWord +=1;
            }
            return (numberOfWord);
        }
    }
}
