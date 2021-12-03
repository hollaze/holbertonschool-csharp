using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        string topItem = "";
        bool containsSearch = false, firstItem = false;
        int count = 0, index = 0;

        foreach (string str in aQueue)
        {
            count += 1;
            if (firstItem == false)
            {
                topItem = str;
                firstItem = true;
            }

            if (str == search)
            {
                containsSearch = true;
                index = count;
            }
        }

        if (containsSearch == true)
        {
            for (int i = 0; i < index; i++)
                aQueue.Dequeue();
        }
        aQueue.Enqueue(newItem);

        Console.WriteLine("Number of items: {0}", count);
        if (count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: {0}", topItem);

        if (aQueue.Contains(search))
            containsSearch = true;

        Console.WriteLine("Queue contains \"{0}\": {1}", search, containsSearch);

        return (aQueue);
    }
}
