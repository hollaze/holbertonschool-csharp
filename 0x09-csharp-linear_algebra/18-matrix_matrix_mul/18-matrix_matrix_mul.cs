using System;

/// <summary>
/// Math Matrix
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiply 2 matrices
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>Result of the multiplication</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return (new double[,] { { -1 } });

        // rows and columns
        double[,] matrixRes = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        // rows of matrix1
        for (int row = 0; row < matrix1.GetLength(0); row++)
        {
            // columns of matrix2
            for (int col = 0; col < matrix2.GetLength(1); col++)
            {
                for (int i = 0; i < matrix1.GetLength(1); i++)
                {
                    matrixRes[row, col] += matrix1[row, i] * matrix2[i, col];
                }
            }
        }

        return (matrixRes);
    }
}
