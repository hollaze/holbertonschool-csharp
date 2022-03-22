﻿using System;
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

/// <summary>
/// Decoration class.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }
    
    /// <summary>
    /// Initializes a new instance of <see cref="Decoration"/> class.
    /// </summary>
    /// <param name="name">Name of the item.</param>
    /// <param name="durability">Durability of the item.</param>
    /// <param name="isQuestItem"></param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {   
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
        
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
    }
    
    /// <summary>
    /// Interact function.
    /// </summary>
    public void Interact()
    {
        if (this.durability <= 0)
            Console.WriteLine($"The {this.name} has been broken.");
        else if (this.isQuestItem)
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        else if (!this.isQuestItem)
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
    }
    
    /// <summary>
    /// Break function.
    /// </summary>
    public void Break()
    {
        this.durability -= 1;
        
        if (this.durability > 0)
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        else if (this.durability == 0)
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        else
            Console.WriteLine($"The {this.name} is already broken.");
    }
}
