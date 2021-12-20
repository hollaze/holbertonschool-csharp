using System;

/// <summary>
/// Shape class.
/// </summary>
class Shape
{
    /// <summary>
    /// Throw error if Area method is not implemented
    /// </summary>
    /// <returns></returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
