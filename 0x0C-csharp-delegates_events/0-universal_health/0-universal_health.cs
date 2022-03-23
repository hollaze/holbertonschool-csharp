using System;


/// <summary>
/// Player class.
/// </summary>
class Player
{
    /// <summary>Gets or sets name.</summary>
    private string name { get; set; }

    /// <summary>Gets or sets maxHp.</summary>
    private float maxHp { get; set; }

    /// <summary>Gets or sets hp.</summary>
    private float hp { get; set; }

    private delegate void CalculateHealth(float value);

    /// <summary>Initializes a new instance of the <see cref="Player"/> class.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// PrintHealth method.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
