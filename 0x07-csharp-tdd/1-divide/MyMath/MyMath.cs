using System;

namespace MyMath
{
    /// <summary>
    /// Matrix class
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divide all elements in matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="num">divide the elements by num</param>
        /// <returns></returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int[,] newMatrix = matrix;

            if (matrix == null || newMatrix == null)
                return (null);

            try
            {
                for (int i = 0; i < newMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < newMatrix.GetLength(1); j++)
                    {
                        newMatrix[i, j] /= num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }

            return (newMatrix);
        }
    }
}
