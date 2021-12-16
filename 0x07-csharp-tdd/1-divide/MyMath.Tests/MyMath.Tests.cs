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
            public void Test1()
            {
                int[,] newMatrix = new int[3, 3];
                int num = 3;

                newMatrix = new int[,] { { 18, -64, 30 }, { 78, 21, 0 }, { 100, -98, 65489 } };

                newMatrix = MyMath.Matrix.Divide(newMatrix, num);
                Assert.AreNotEqual(0, num);
            }

            [Test]
            public void Test2()
            {
                int[,] newMatrix = new int[0, 2];
                int num = 3;

                newMatrix = new int[,] { { 185694982, -64, 0 } };
                newMatrix = MyMath.Matrix.Divide(newMatrix, num);

                Assert.IsNotNull(newMatrix);
            }

            [Test]
            public void Test3()
            {
                int[,] newMatrix = new int[0, 2];
                int num = 3, val1 = 185694982;

                newMatrix = new int[,] { { 185694982, -64, 0 } };
                newMatrix = MyMath.Matrix.Divide(newMatrix, num);

                Assert.AreEqual(val1 / num, newMatrix[0, 0]);
            }

        }
    }
}
