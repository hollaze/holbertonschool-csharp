using System;
using System.ComponentModel;

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
/// Door class.
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Door"/> class.
    /// </summary>
    /// <param name="name">door</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interact function.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}
