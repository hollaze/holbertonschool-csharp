using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {


        [TestFixture]
        public class tests1
        {
            [Test]
            public void Test1()
            {
                int a = 5, b = 11, res;

                res = Operations.Add(a, b);
                Assert.AreEqual(a+b, res);

            }
            [Test]
            public void Test2()
            {
                int a = 5, b = 11, res;

                res = Operations.Add(a, b);
                Assert.AreNotEqual(17, res);
            }


        }
    }
}
