using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStacksQueuesAndBags
{
    //class LinkedListQueueOfStrings 
    class LinkedListQueueOfStrings<T>
    {
        private Node Head = null;
        private Node Tail = null;

        private class Node
        {
            //public string Item; 
            public T Item;
            public Node Next;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        //public void Enqueue(string item)  
        public void Enqueue(T item)
        {
            Node lastNode = Tail;
            Tail = new Node
            {
                Item = item,
                Next = null
            };

            if (IsEmpty())
            {
                Head = Tail;
            }
            else
            {
                lastNode.Next = Tail;
            }
        }

        //public string Dequeue() 
        public T Dequeue()
        {
            //string itemToDelete = Head.Item; 
            T itemToDelete = Head.Item;
            Head = Head.Next;
            if (IsEmpty())
            {
                Tail = null;
            }
            return itemToDelete;
        }
    }
}
