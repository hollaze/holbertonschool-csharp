using System;


/// <summary>
/// Base class.
/// </summary>
abstract class Base
{
    /// <summary>Gets or sets the name.</summary>
    public string name { get; set; }
    
    /// <summary>
    /// Override .ToString() method.
    /// </summary>
    /// <returns>Name and type.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}
