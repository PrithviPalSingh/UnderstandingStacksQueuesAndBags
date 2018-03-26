using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStacksQueuesAndBags
{
    class LinkedListQueueOfStrings
    {
        private Node Head = null;
        private Node Tail = null;

        private class Node
        {
            public string Item;
            public Node Next;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Enqueue(string item)
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

        public string Dequeue()
        {
            string itemToDelete = Head.Item;
            Head = Head.Next;
            if (IsEmpty())
            {
                Tail = null;
            }
            return itemToDelete;
        }
    }
}
