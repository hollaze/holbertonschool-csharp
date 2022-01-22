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
        double[,] matrixRotation2D = new double[,] { { cos, -sin },
                                                     { sin, cos } };
        double[,] matrixRes = new double[2, 2];
        double storeNumber;


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                storeNumber = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    storeNumber += matrixRotation2D[col, i] * matrix[row, i];
                }
                // 2 times round because it did not round up with 5 number
                matrixRes[row, col] = Math.Round(storeNumber, 2);
            }
        }

        return (matrixRes);
    }
}
