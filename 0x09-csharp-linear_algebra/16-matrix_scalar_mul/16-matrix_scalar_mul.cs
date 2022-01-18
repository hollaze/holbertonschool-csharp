using System;

/// <summary>
/// Math Matrix
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiply matrix by a scalar number
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="scalar"></param>
    /// <returns>Multiplied matrix</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // Check if matrix is 2D or 3D
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 ||
            matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
        {
            return (new double[,] { { -1 } });
        }

        double[,] matrixRes = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrixRes[i, j] = matrix[i, j] * scalar;
            }
        }

        return (matrixRes);
    }
}
