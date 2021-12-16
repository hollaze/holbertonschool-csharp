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
            public void TestIsDividedByZero()
            {
                int[,] newMatrix = new int[3, 3];
                int num = 3;

                newMatrix = new int[,] { { 18, -64, 30 }, { 78, 21, 0 }, { 100, -98, 65489 } };

                newMatrix = MyMath.Matrix.Divide(newMatrix, num);
                Assert.AreNotEqual(0, num);
            }

            [Test]
            public void TestIsMatrixNull()
            {
                int[,] newMatrix = new int[0, 2];
                int num = 3;

                newMatrix = new int[,] { { 185694982, -64, 0 } };
                newMatrix = MyMath.Matrix.Divide(newMatrix, num);

                Assert.IsNotNull(newMatrix);
            }

            [Test]
            public void TestGoodResult()
            {
                int[,] newMatrix = new int[0, 2];
                int num = 3, val1 = 185694982;

                newMatrix = new int[,] { { 185694982, -64, 0 } };
                newMatrix = MyMath.Matrix.Divide(newMatrix, num);

                Assert.AreEqual(val1 / num, newMatrix[0, 0]);
            }

            [Test]
            public void TestIndexOutOfRange()
            {
                int[,] newMatrix = new int[0, 2];
                int num = 3;

                newMatrix = new int[,] { { 185694982, -64, 0 } };
                newMatrix = MyMath.Matrix.Divide(newMatrix, num);

                if (newMatrix.GetLength(0) > MyMath.Matrix.Divide(newMatrix, num).GetLength(0)
                    || newMatrix.GetLength(1) > MyMath.Matrix.Divide(newMatrix, num).GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index out of range");
                    throw new ArgumentOutOfRangeException("Argument out of range");
                }

                Assert.Pass();
            }
        }
    }
}
