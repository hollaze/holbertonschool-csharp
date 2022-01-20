using System;

/// <summary>
/// Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates rotation of 2 vectors in matrix
    /// </summary>
    /// <param name="matrix">2D matrix</param>
    /// <param name="angle">Radians</param>
    /// <returns>New matrix with its new vectors positions</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if matrix is 2D
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (new double[,] { { -1 } });

        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);
        double[,] matrixRotation2D = new double[2, 2];
        double[,] matrixRes = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrixRes[row, col] += matrixRotation2D[col, i] * matrix[row, i];
                }
                matrixRes[row, col] = Math.Round(matrixRes[row, col], 2);
            }
        }

        return (matrixRes);
    }
}
