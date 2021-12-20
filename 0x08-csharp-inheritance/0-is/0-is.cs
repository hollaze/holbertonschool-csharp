using System;
using System.Collections.Generic;

/// <summary>
/// Object class.
/// </summary>
class Obj
{
    /// <summary>
    /// Check if object is of type int.
    /// </summary>
    /// <param name="obj">Object</param>
    /// <returns>Return true if object is an int, false otherwise.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return (true);
        return (false);
    }
}
