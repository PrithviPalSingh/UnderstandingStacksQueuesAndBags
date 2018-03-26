using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStacksQueuesAndBags
{
    class LinkedListStacksOfStrings
    {
        private Node head = null;

        private class Node
        {
            public string Item;
            public Node Next;
        }       

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Push(string str)
        {
            Node OldHead = head;

            head = new Node
            {
                Item = str,
                Next = OldHead
            };
        }

        public string Pop()
        {
            string itemToDelete = head.Item;
            head = head.Next;
            return itemToDelete;
        }

        public int Size()
        {
            int N = 0;

            while (head != null)
            {
                N++;
            }

            return N;
        }
    }
}
