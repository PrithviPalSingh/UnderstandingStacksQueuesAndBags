using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStacksQueuesAndBags
{
    class DynamicCountArracyStackOfStrings
    {
        private string[] array = null;
        private int N = 0;

        public DynamicCountArracyStackOfStrings()
        {
            array = new string[1];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public void Push(string str)
        {
            if (array.Length == N)
            {
                ResizeArray(2 * array.Length);
            }

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

            if (N > 0 && N == array.Length / 4) ////Avoid thrashing by refreshing when array is quarter full instead of half.
            {
                ResizeArray(array.Length / 2);
            }

            return itemToDelete;
        }

        public int Size()
        {
            return N;
        }

        private void ResizeArray(int capacity)
        {
            string[] newArray = new string[capacity];
            for (int i = 0; i < N; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
    }
}
