using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStacksQueuesAndBags
{
    /// <summary>
    /// Takes constant amortize time (gradually write off the initial cost of (an asset) over a period).
    /// </summary>
    class DynamicCountArracyStackOfStrings // class DynamicCountArracyStackOfStrings<T>
    {
        private string[] array = null; // private T[] array = null;
        private int N = 0;

        public DynamicCountArracyStackOfStrings()
        {
            array = new string[1]; //  array = (T[]) new object[1];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        /// <summary>
        /// Cost of inserting:
        /// N (1 array access per push) + (2 + 4 + 8 +...........+ N) ~ 3N
        /// </summary>
        /// <param name="str"></param>
        public void Push(string str) // public void Push(T str)
        {
            if (array.Length == N)
            {
                ResizeArray(2 * array.Length);
            }

            array[N++] = str;
        }

        //Avoid Loitering, so that garbage collector can reclaim the memory.
        public string Pop()  // public T Pop()
        {
            if (N < 0)
            {
                return "No item to pop";
            }

            string itemToDelete = array[--N]; // T itemToDelete = array[--N];
            array[N] = null;

            ////Avoid thrashing (push-pop-push-pop when array is half full) by refreshing when array is quarter full instead of half full.
            if (N > 0 && N == array.Length / 4)
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
            string[] newArray = new string[capacity]; // T[] newArray = (T[]) new object[capacity];
            for (int i = 0; i < N; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
    }
}
