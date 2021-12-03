using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current;

        if (myLList.First != null && index >= 0 && index < myLList.Count)
        {
            current = myLList.First;

            for (int i = 0; i < index; i++)
                current = current.Next;
            myLList.Remove(current);
        }
    }
}
