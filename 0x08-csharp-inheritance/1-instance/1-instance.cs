using System;
using System.Collections.Generic;

/// <summary>
/// Object class.
/// </summary>
class Obj
{
    /// <summary>
    /// Check if object is an instance of an array.
    /// </summary>
    /// <param name="obj">Object</param>
    /// <returns>Return true if object is an instance of an array, false otherwise.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
            return (true);
        return (false);
    }
}
