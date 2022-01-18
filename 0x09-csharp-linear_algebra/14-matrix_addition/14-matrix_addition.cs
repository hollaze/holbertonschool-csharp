using System;

/// <summary>
/// Math on matrixes
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Add two matrixes
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>Result between of two matrixes</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Check if matrixes are 2D or 3D and got the same length
        if (matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3 ||
            matrix1.GetLength(1) < 2 || matrix1.GetLength(1) > 3 ||
            matrix2.GetLength(0) < 2 || matrix2.GetLength(0) > 3 ||
            matrix2.GetLength(1) < 2 || matrix2.GetLength(1) > 3 ||
            matrix1.Length != matrix2.Length)
        {
            return (new double[,] { { -1 } });
        }

        double[,] matrixAdd = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrixAdd[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return (matrixAdd);
    }
}

