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
        /// Get the first non-repeating character of a string
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>first non-repeating character of a string, -1 otherwise</returns>
        public static int UniqueChar(string s)
        {
            int index;

            if (s == null || s.Length == 0)
                return (-1);

            for (int i = 0; i < s.Length; i++)
            {
                index = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j] && i != j)
                        index += 1;
                }
                if (index == 0)
                    return (i);
            }
            return (-1);
        }
    }
}
