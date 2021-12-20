using System;
using System.Collections.Generic;

/// <summary>
/// Object class.
/// </summary>
class Obj
{
    /// <summary>
    /// Check if a class is a subclass.
    /// </summary>
    /// <param name="derivedType">Inherited class</param>
    /// <param name="baseType">Base class</param>
    /// <returns></returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return (true);
        return (false);
    }
}
