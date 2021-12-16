using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void TestNull()
        {
            int[,] matrix = MyMath.Matrix.Divide(null, 2);

            Assert.IsNull(matrix);
        }

        [Test]
        public void TestDivideByZero()
        {
            int[,] matrix = new int[,]
            {
                {-2, -1, 0},
                {1, 2, 3},
                {4, 5, 6}
            };

            matrix = MyMath.Matrix.Divide(matrix, 0);

            Assert.IsNull(matrix);
        }

        [Test]
        public void TestGoodResult()
        {
            int num = 3;

            int[,] matrix = new int[,]
            {
                { 1856949, -64, 0 }
            };

            int[,] goodResult = new int[,]
            {
                { matrix[0, 0] / num, matrix[0, 1] / num, matrix[0, 2] / num}
            };

            matrix = MyMath.Matrix.Divide(matrix, num);

            Assert.AreEqual(goodResult, matrix);
        }

        [Test]
        public void TestIndexOutOfRange()
        {
            int num = 3;

            int[,] matrix = new int[,]
            {
                { 185694982, -64, 0 }
            };

            matrix = MyMath.Matrix.Divide(matrix, num);

            if (matrix.GetLength(0) > MyMath.Matrix.Divide(matrix, num).GetLength(0)
                || matrix.GetLength(1) > MyMath.Matrix.Divide(matrix, num).GetLength(1))
            {
                throw new IndexOutOfRangeException("Index out of range");
                throw new ArgumentOutOfRangeException("Argument out of range");
            }

            Assert.Pass();
        }

        [Test]
        public void TestType()
        {
            int[,] matrix = new int[0, 0];

            Assert.AreEqual(typeof(int[,]), MyMath.Matrix.Divide(matrix, 3).GetType());
        }
    }
}
