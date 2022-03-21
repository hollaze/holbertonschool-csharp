using System;

/// <summary>
/// Generic class
/// </summary>
/// <typeparam name="T">Generic type</typeparam>
class Queue<T>
{
    /// <summary>
    /// Check type of T
    /// </summary>
    /// <returns>Queue's type</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
