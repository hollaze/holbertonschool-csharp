using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        bool containsSearch = false;

        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: {0}", aQueue.Peek());

        if (aQueue.Contains(search))
            containsSearch = true;

        if (aQueue.Contains(search))
        {
            for (int i = 0; i < aQueue.Count; i++)
                aQueue.Dequeue();
            Console.WriteLine("Queue contains \"{0}\": {1}", search, containsSearch);
        }

        aQueue.Enqueue(newItem);

        return (aQueue);
    }
}
