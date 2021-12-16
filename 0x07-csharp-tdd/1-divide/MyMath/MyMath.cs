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
            int [,] newMatrix;

            if (matrix == null)
                return (null);
            
            newMatrix = (int[,]) matrix.Clone();

            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
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

            return (matrix);
        }
    }
}
