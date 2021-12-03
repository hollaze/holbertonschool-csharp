using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current;

        if (myLList == null)
            return (null);

        if (myLList.First == null)
            myLList.AddFirst(n);

        else
        {
            current = myLList.First;

            while (current != null)
            {
                if (myLList.Last.Value < n)
                {
                    myLList.AddLast(n);
                    break;
                }

                if (current.Value < n)
                    current = current.Next;
                else
                {
                    myLList.AddBefore(current, n);
                    break;
                }
            }
        }

        return (myLList.First);
    }
}
