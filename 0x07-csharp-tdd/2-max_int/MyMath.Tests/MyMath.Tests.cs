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
            List<int> nums = new List<int>() { -687, 0, 184987, 26, -2354699, 99999999, 1, 2, 3 };
            int maxInt;

            maxInt = MyMath.Operations.Max(nums);
            Assert.AreEqual(99999999, maxInt);
        }

        [Test]
        public void TestNull()
        {
            List<int> nums = null;

            Assert.AreEqual(0, MyMath.Operations.Max(nums));
        }
    }
}
