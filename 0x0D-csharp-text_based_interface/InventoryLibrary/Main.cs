using System;
//using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program : BaseClass
{
    static void Main()
    {
        Console.WriteLine("BaseClass:\n");
        BaseClassTest();

        Console.WriteLine("\nItem:\n");
        ItemTest();

        Console.WriteLine("\nUser:\n");
        UserTest();

        Console.WriteLine("\nInventory:\n");
        InventoryTest();
    }

    static void BaseClassTest()
    {
        BaseClass baseClass = new BaseClass();

        Console.WriteLine(baseClass.ToString());
    }

    static void ItemTest()
    {
        Item pot = new Item("Pot", "ceramic pot", 25.1551f);

        pot.tags = new List<string>();

        pot.tags.AddRange(new List<string>
        {
            new string ("pot"),
            new string ("ceramic"),
        });

        Console.WriteLine(pot.ToString());
    }

    static void UserTest()
    {
        User player = new User("Player");

        Console.WriteLine(player.ToString());
    }

    static void InventoryTest()
    {
        Inventory inventory = new Inventory();
        inventory.Quantity = -100;

        Console.WriteLine(inventory.Item_id);
        Console.WriteLine(inventory.User_id);
        Console.WriteLine(inventory.Quantity);
    }
}
