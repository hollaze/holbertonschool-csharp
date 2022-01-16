using System;

/// <summary>
/// Math Vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Magnitude of a vector
    /// </summary>
    /// <param name="vector"></param>
    /// <returns>Vector magnitude</returns>
    public static double Magnitude(double[] vector)
    {
        double magnitude = 0;

        if (vector.Length < 2 || vector.Length > 3)
            return (-1);

        foreach (double value in vector)
            magnitude += Math.Pow(value, 2);

        return (Math.Round(Math.Sqrt(magnitude), 2));
    }
}
