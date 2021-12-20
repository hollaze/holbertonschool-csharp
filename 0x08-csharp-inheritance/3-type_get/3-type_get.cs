using System;

/// <summary>
/// Object class.
/// </summary>
class Obj
{
    /// <summary>
    /// Print object properties and methods.
    /// </summary>
    /// <param name="myObj">object</param>
    public static void Print(object myObj)
    {
        string myObjTypeName = myObj.GetType().Name;
        Type myObjType = myObj.GetType();

        Console.WriteLine($"{myObjTypeName} Properties:");
        foreach (var property in myObjType.GetProperties())
            Console.WriteLine(property.Name);
        
        Console.WriteLine($"{myObjTypeName} Methods:");
        foreach (var method in myObjType.GetMethods())
            Console.WriteLine(method.Name);
    }
}
