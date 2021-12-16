using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    public class Tests
    {


        [TestFixture]
        public class tests1
        {
            [Test]
            public void goodResult()
            {
                int a = 5, b = 11, res;

                res = Operations.Add(a, b);
                Assert.AreEqual(a + b, res);

            }
            [Test]
            public void badResult()
            {
                int a = 5, b = 11, res;

                res = Operations.Add(a, b);
                Assert.AreNotEqual(17, res);
            }
            [Test]
            public void type()
            {
                int a = 5, b = 11;

                Assert.AreEqual(typeof(int), Operations.Add(a, b).GetType());
            }
        }
    }
}
