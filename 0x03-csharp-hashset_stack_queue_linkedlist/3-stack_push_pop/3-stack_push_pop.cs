using System;
using System.Collections.Generic;


class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        string topItem = aStack.Peek();
        bool findSearch = false;

        Console.WriteLine("Number of items: {0}", aStack.Count);

        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", topItem);

        for (int i = 0; i <= aStack.Count; i++)
                aStack.Pop();
        
        if (search.Length > 0)
            findSearch = true;

        Console.WriteLine("Stack contains \"{0}\": {1}", search, findSearch);

        aStack.Push(newItem);

        return (aStack);
    }
}

