using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Item : BaseClass
{
    private string name { get; set; } = "Item";
    public string description { get; set; } = "description";


    // limit to 2 decimal points
    private float price = 0.00f;

    public float Price
    {
        get { return (float)Math.Round(this.price, 2); }
        set { this.price = (float)Math.Round(value, 2); }
    }


    // Item tags, like twitch tags, usefull for searching type of Item
    public List<string> tags { get; set; }

    // Would like a better way to initialize the description
    public Item(string name = "Item", string description = "description", float price = 0f)
    {
        Update();
        this.id = GenerateId();
        this.name = name;
        this.description = description;

        if (price < 0f)
            price = 0f;

        this.price = price;
    }

    public override string ToString()
    {
        string tags = null;

        foreach (string tag in this.tags)
        {
            tags += tag + ((tag == this.tags.Last()) ? " " : ", ");
        }

        string itemCreated = $"Item created: {this.date_created}";
        string itemUpdated = $"Item updated: {this.date_updated}";
        string itemId = $"Item id: {this.id}";
        string itemName = $"Item name: {this.name}";
        string itemDescription = $"Item description: {this.description}";
        string itemPrice = $"Item price: {this.Price}";
        string itemTags = $"Item tags: {tags}";

        return $"{itemCreated}\n{itemUpdated}\n{itemId}\n{itemName}\n{itemDescription}\n{itemPrice}\n{itemTags}";
    }

    /*public void Add(T item)
    {
        itemList.Add(item);
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)itemList).GetEnumerator();
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)itemList).GetEnumerator();
    }*/
}
