using System;

public class BaseClass
{
    // generate id
    public string id { get; set; }

    // Enter all dates in JSON
    // date of first used command
    // date_created used on creating new item
    // can only be used once per item
    public DateTime date_created { get; }

    // Enter all dates in JSON
    // Update on command use
    // date_updated, update on updating item
    public DateTime date_updated;

    // Creation of BaseClass object
    public BaseClass()
    {
        this.id = GenerateId();
        this.date_created = DateTime.Now;
        this.date_updated = DateTime.Now;
    }
    
    // Generate object id
    public string GenerateId()
    {
        Guid generateId = Guid.NewGuid();

        return generateId.ToString();
    }
    
    public void Update()
    {
        this.date_updated = DateTime.Now;
    }

    public override string ToString()
    {
        string baseClassCreated = $"BaseClass created: {this.date_created}";
        string baseClassUpdated = $"BaseClass updated: {this.date_updated}";
        string baseClassId = $"BaseClass id: {this.id}";
        
        return $"{baseClassCreated}\n{baseClassUpdated}\n{baseClassId}";
    }
}
