using System;

public class User : BaseClass
{
    public string name { get; set; } = "User";

    public User(string name = "User")
    {
        Update();
        this.id = GenerateId();
        this.name = name;
    }

    public override string ToString()
    {
        string userCreated = $"User created: {this.date_created}";
        string userUpdated = $"User updated: {this.date_updated}";
        string userId = $"User id: {this.id}";
        string userName = $"User name: {this.name}";

        return $"{userCreated}\n{userUpdated}\n{userId}\n{userName}";
    }
}
