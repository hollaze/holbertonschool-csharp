using System;
using System.Collections.Generic;

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

/// <summary>
/// Rectangle class inheritin Shape class.
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    /// <value>width</value>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    /// <value>height</value>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}
