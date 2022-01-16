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

        if (vector.Length == 2)
        {
            magnitude = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2);
        }

        else if (vector.Length == 3)
        {
            magnitude = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2);
        }

        return (Math.Round(2, Math.Sqrt(magnitude)));
    }
}
