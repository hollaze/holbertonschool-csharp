using System;

namespace Text
{
    /// <summary>
    /// String class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Check if string is a palindrome
        /// </summary>
        /// <param name="s">string to check</param>
        /// <returns>true if string is a palindrome</returns>
        public static bool IsPalindrome(string s)
        {
            string newString = "";
            string reverseString = "";

            if (s == "")
                return (true);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 65 && s[i] <= 90
                    || s[i] >= 97 && s[i] <= 122)
                {
                    newString += s[i];
                }
            }

            newString = newString.ToLower();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] >= 65 && s[i] <= 90
                    || s[i] >= 97 && s[i] <= 122)
                {
                    reverseString += s[i];
                }
            }

            reverseString = reverseString.ToLower();

            if (newString == reverseString)
                return (true);
            return (false);
        }
    }
}
