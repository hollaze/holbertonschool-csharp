using System;

/// <summary>
/// Vector math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiply vectors - scaling
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns>Scaled vector</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] scaledVector = new double[3];

        if (vector.Length < 2 || vector.Length > 3)
            return (-1);
        
        for (int i = 0; i < vector.Length; i++)
            scaledVector[i] = vector[i] * scalar;
        
        return (scaledVector);
    }
}

