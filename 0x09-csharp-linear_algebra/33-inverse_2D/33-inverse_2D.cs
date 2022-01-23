using System;

/// <summary>
/// Matrix Determinant
/// </summary>
class DeterminantMatrix
{
    /// <summary>
    /// Determinant of 2x2 or 3x3 matrix
    /// </summary>
    /// <param name="matrix">2x2 or 3x3 matrix</param>
    /// <returns>Determinant of the matrix</returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 ||
            matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3 ||
            matrix.GetLength(0) != matrix.GetLength(1))
        {
            return ((double) -1);
        }

        double determinant2x2 = 0;

        if (matrix.GetLength(0) == 2)
        {
            determinant2x2 = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return (Math.Round(determinant2x2, 2));
        }

        // I really hate static code (when it's my code)
        // but doing determinant algorithm for NxN matrix is
        // too much for me, sorry for the one that sees this
        // (sorry for myself too ...)
        
        // Also doing the 3x3 algorithm the way I was thinking
        // would have made the code way longer and way less clear

        // Positive and Negative
        double determinant3x3Pos = 0;
        double determinant3x3Neg = 0;

        determinant3x3Pos = matrix[0, 0] * matrix[1, 1] * matrix[2, 2];
        determinant3x3Pos += (matrix[0, 1] * matrix[1, 2] * matrix[2, 0]);
        determinant3x3Pos += (matrix[0, 2] * matrix[1, 0] * matrix[2, 1]);

        determinant3x3Neg = determinant3x3Pos - (matrix[0, 2] * matrix[1, 1] * matrix[2, 0]);
        determinant3x3Neg -= (matrix[0, 1] * matrix[1, 0] * matrix[2, 2]);
        determinant3x3Neg -= (matrix[0, 0] * matrix[1, 2] * matrix[2, 1]);

        return (Math.Round(determinant3x3Neg, 2));
    }
}

/// <summary>
/// Scalar Matrix
/// </summary>
class ScalarMatrix
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

/// <summary>
/// Math Matrix
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Inverse 2D matrix
    /// </summary>
    /// <param name="matrix">2D matrix</param>
    /// <returns>inversed 2D matrix</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2 ||
            DeterminantMatrix.Determinant(matrix) == 0)
        {
            return (new double[,] { { -1 } });
        }
        
        double inverseDeterminant = 1 / DeterminantMatrix.Determinant(matrix);
        return (ScalarMatrix.MultiplyScalar(matrix, inverseDeterminant));  
    }
}
