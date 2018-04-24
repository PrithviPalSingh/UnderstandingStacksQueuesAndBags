using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStacksQueuesAndBags
{
    class FixedCapacityStackOfStrings //class FixedCapacityStackOfStrings<T>
    {
        private string[] array = null; // private T[] array = null;
        private int N = 0;

        public FixedCapacityStackOfStrings(int capacity)
        {
            array = new string[capacity]; // array = (T[]) new object[capacity];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public void Push(string str) // public void Push(T str)
        {
            array[N++] = str;
        }

        /// <summary>
        /// Avoid Loitering (stand or wait around without apparent purpose.), so that garbage collector can reclaim the memory.
        /// </summary>
        /// <returns></returns>
        public string Pop() // public T Pop()
        {
            if (N < 0)
            {
                return "No item to pop";
            }

            string itemToDelete = array[--N]; //T itemToDelete = array[--N];
            array[N] = null;
            return itemToDelete;
        }

        public int Size()
        {
            return N;
        }
    }
}
