using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStacksQueuesAndBags
{
    class FixedCapacityStackOfStrings
    {
        private string[] array = null;
        private int N = 0;

        public FixedCapacityStackOfStrings(int capacity)
        {
            array = new string[capacity];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public void Push(string str)
        {
            array[N++] = str;
        }

        //Avoid Loitering, so that garbage collector can reclaim the memory.
        public string Pop()
        {
            if (N < 0)
            {
                return "No item to pop";
            }

            string itemToDelete = array[--N];
            array[N] = null;
            return itemToDelete;
        }

        public int Size()
        {
            return N;
        }
    }
}
