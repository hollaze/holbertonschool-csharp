using System;

/// <summary>
/// Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Shearing 2D matrix
    /// </summary>
    /// <param name="matrix">2D matrix</param>
    /// <param name="direction">x or y axis</param>
    /// <param name="factor">Shearing factor</param>
    /// <returns>Sheared 2D matrix</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2 ||
            direction != 'x' && direction != 'y')
            return (new double[,] { { -1 } });

        double[,] matrixRes = new double[2, 2];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (direction == 'x' && col == 0)
                {
                    matrixRes[row, col + 1] = matrix[row, col + 1];
                    matrixRes[row, col] = matrix[row, col] + factor * matrix[row, col + 1];
                }
                else if (direction == 'y' && col == 1)
                {
                    matrixRes[row, col - 1] = matrix[row, col - 1];
                    matrixRes[row, col] = matrix[row, col] + factor * matrix[row, col - 1];
                }
            }
        }

        return (matrixRes);
    }
}
