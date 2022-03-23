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

    /// <summary>
    /// CalculateHealth delegate.
    /// </summary>
    /// <param name="value"></param>
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

    /// <summary>
    /// TakeDamage method.
    /// </summary>
    /// <param name="damage">Damage taken.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;

        this.hp -= damage;
        ValidateHP(this.hp);

        Console.WriteLine($"{this.name} takes {damage} damage!");
    }

    /// <summary>
    /// HealDamage method.
    /// </summary>
    /// <param name="heal">Heal taken.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;

        this.hp += heal;
        ValidateHP(this.hp);

        Console.WriteLine($"{this.name} heals {heal} HP!");
    }

    /// <summary>
    /// ValdateHP if damage or heal is too big.
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }

    /// <summary>
    /// ApplyModifier method.
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue /= 2f;
            case Modifier.Strong:
                return baseValue *= 1.5f;
        }

        return baseValue;
    }
}

/// <summary>
/// Enum Modifier.
/// </summary>
public enum Modifier
{
    /// <summary>Weak modifier.</summary>
    Weak,
    /// <summary>Base modifier.</summary>
    Base,
    /// <summary>Strong modifier.</summary>
    Strong
}

/// <summary>
/// CalculateModifier delegate.
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns>Float value.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
