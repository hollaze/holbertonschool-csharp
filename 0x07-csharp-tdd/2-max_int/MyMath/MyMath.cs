using System;
using System.Linq;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Operations class
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Max integer in a list
        /// </summary>
        /// <param name="nums">list of integers</param>
        /// <returns>max integer in nums list</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0 || nums == null)
                return (0);
            return (nums.Max());
        }
    }
}
