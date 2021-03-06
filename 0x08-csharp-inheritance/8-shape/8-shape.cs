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
/// Rectangle class inheriting Shape class.
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

    /// <summary>
    /// Get area value of the Rectangle.
    /// </summary>
    /// <returns>Area of the rectangle.</returns>
    public new int Area()
    {
        return (width * height);
    }

    /// <summary>
    /// Print width and height  of the rectangle.
    /// </summary>
    /// <returns>String</returns>
    public override string ToString()
    {
        return ($"[Rectangle] {width} / {height}");
    }
}

/// <summary>
/// Square class inheriting from Rectangle class.
/// </summary>
class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets or sets the size.
    /// </summary>
    /// <value>size</value>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                this.size = value;
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
