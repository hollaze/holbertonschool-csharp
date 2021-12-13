using System;

enum Rating
{
Good,
Great,
Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    public Dog(string name, float age, string name, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = name;
        this.rating = rating;
    }

    public override string ToString()
    {
        return ("Dog name: " + name + "\nAge: " + age + "\nOwner: " + owner + "\nRating: " + rating);
    }
}
