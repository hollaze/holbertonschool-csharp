using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void TestNull()
        {
            int [,] output = MyMath.Matrix.Divide(null, 2);

            Assert.IsNull(output);
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
            int num = 3, val1 = 1856949, res = val1 / num;

            newMatrix = new int[,] { { 1856949, -64, 0 } };
            newMatrix = MyMath.Matrix.Divide(newMatrix, num);

            Assert.AreEqual(res, newMatrix[0, 0]);
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

        [Test]
        public void TestType()
        {
            int[,] newMatrix = new int[0, 2];
            int num = 3;

            Assert.AreEqual(typeof(int[,]), MyMath.Matrix.Divide(newMatrix, num).GetType());
        }

        [Test]
        public void TestEmpty()
        {
            Assert.Pass();
        }
    }
}
