using System;

/// <summary>
/// Vector math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Add two vectors
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>Sum of the two vectors</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] vectorSum = new double[3];

        if (vector1.Length < 2 || vector1.Length > 3
            || vector2.Length < 2 || vector2.Length > 3
            || vector1.Length != vector2.Length)
            return (new double[1] { -1 });

        for (int i = 0; i < vector1.Length; i++)
        {
            vectorSum[i] = vector1[i] + vector2[i];
        }

        return (vectorSum);
    }
}
