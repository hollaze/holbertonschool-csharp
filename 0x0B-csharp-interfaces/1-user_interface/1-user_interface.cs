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
    /// <returns>Name and class type.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}

/// <summary>
/// IInteractive interface.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact method.
    /// </summary>
    void Interact();
}

/// <summary>
/// IBreakable interface.
/// </summary>
public interface IBreakable
{
    /// <summary>Gets or sets the durability.</summary>
    int durability { get; set; }

    /// <summary>
    /// Break method.
    /// </summary>
    void Break();
}

/// <summary>
/// ICollectable interface.
/// </summary>
public interface ICollectable
{
    /// <summary>Gets or sets isCollected.</summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect method.
    /// </summary>
    void Collect();
}

/// <summary>
/// TestObject class used for testing type,
/// properties and method implementation.
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>Gets or sets the durability.</summary>
    public int durability { get; set; }

    /// <summary>Gets or sets isCollected.</summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Interact function.
    /// </summary>
    public void Interact()
    {

    }

    /// <summary>
    /// Break function.
    /// </summary>
    public void Break()
    {

    }

    /// <summary>
    /// Collect function.
    /// </summary>
    public void Collect()
    {

    }
}
