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
    public Dog(string dogName, float dogAge, string ownerName, Rating dogRating)
    {
        name = dogName;
        age = dogAge;
        owner = ownerName;
        rating = dogRating;
    }

    public override string ToString()
    {
        return ("Dog name: " + name + "\nAge: " + age + "\nOwner: " + owner + "\nRating: " + rating);
    }
}
