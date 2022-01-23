using System;

/// <summary>
/// Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Determinant of 2x2 or 3x3 matrix
    /// </summary>
    /// <param name="matrix">2x2 or 3x3 matrix</param>
    /// <returns>Determinant of the matrix</returns>
    public static double Determinant(double[,] matrix)
    {
        int matrixLength = matrix.GetLength(0);

        if (matrixLength < 2 || matrixLength > 3 ||
            matrix.GetLength(0) != matrix.GetLength(1))
        {
            return (new double[,] { { -1 } });
        }

        double determinant2x2 = 0;

        if (matrixLength == 2)
        {
            determinant2x2 = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return (determinant2x2);
        }

        // I really hate static code (when it's my code)
        // but doing determinant algorithm for NxN matrix is
        // too much for me, sorry for the one that sees this
        // (sorry for myself too ...)

        // Positive and Negative
        double determinant3x3Pos = 0;
        double determinant3x3Neg = 0;

        determinant3x3Pos = matrix[0, 0] * matrix[1, 1] * matrix[2, 2];
        determinant3x3Pos += ( matrix[0, 1] * matrix[1, 2] * matrix[2, 0] );
        determinant3x3Pos += ( matrix[0, 2] * matrix[1, 0] * matrix[2, 1] );

        determinant3x3Neg = matrix[0, 2] * matrix[1, 1] * matrix[3, 0];
        determinant3x3Neg -= ( matrix[0, 1] * matrix[1, 0] * matrix[2, 2] );
        determinant3x3Neg -= ( matrix[0, 0] * matrix[1, 2] * matrix[2, 1] );

        return (Math.Round(determinant3x3Pos - determinant3x3Neg), 2);
    }
}
