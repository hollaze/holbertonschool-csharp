using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void TestEmpty()
        {
            List<int> nums = new List<int>();
            Assert.AreEqual(0, MyMath.Operations.Max(nums));
        }

        [Test]
        public void TestMaxInteger()
        {
            List<int> nums = new List<int>() { -687, 0, 18498, 26, -23549, 999999, 1, 2, 3 };
            int maxInt = 0;

            maxInt = MyMath.Operations.Max(nums);
            Assert.AreEqual(999999, maxInt);

            nums.Clear();
            nums = new List<int>() { 5, 4, 3, 2, 1, 0 };

            maxInt = MyMath.Operations.Max(nums);
            Assert.AreEqual(5, maxInt);

            nums.Clear();
            nums = new List<int>() { -3, -2, -1, -3, -4, -5, -1 };

            maxInt = MyMath.Operations.Max(nums);
            Assert.AreEqual(-1, maxInt);
        }
    }
}
