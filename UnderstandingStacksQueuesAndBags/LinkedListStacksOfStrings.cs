using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStacksQueuesAndBags
{
    /// <summary>
    /// Every operation takes a constant time.
    /// Desirable one.
    /// </summary>

    //class LinkedListStacksOfStrings 
    class LinkedListStacksOfStrings<T> : IEnumerable<T>
    {
        private Node head;

        public class Node
        {
            //public string Item; 
            public T Item;
            public Node Next;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        //public void Push(string str) 
        public void Push(T str)
        {
            Node OldHead = head;

            head = new Node
            {
                Item = str,
                Next = OldHead
            };
        }

        //public string Pop() 
        public T Pop()
        {
            //string itemToDelete = head.Item; 
            T itemToDelete = head.Item;
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

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }        
    }
}
