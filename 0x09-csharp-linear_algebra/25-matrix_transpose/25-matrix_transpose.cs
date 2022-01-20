using System;

/// <summary>
/// Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Transpose matrix
    /// </summary>
    /// <param name="matrix">Matrix to transpose</param>
    /// <returns>Transposed matrix</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return (new double[0, 0]);
        
        double[,] matrixTransposed = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                matrixTransposed[row, col] = matrix[col, row];
            }
        }

        return (matrixTransposed);
    }
}
