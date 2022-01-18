using System;

/// <summary>
/// Vector Math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Dot product of vectors
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>Dot product result</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double dotResult = 0;

        if (vector1.Length != vector2.Length ||
            vector1.Length < 2 || vector1.Length > 3 ||
            vector2.Length < 2 || vector2.Length > 3)
            return (-1);

        for (int i = 0; i < vector1.Length; i++)
        {
            dotResult += vector1[i] * vector2[i];
        }

        return (dotResult);
    }
}
