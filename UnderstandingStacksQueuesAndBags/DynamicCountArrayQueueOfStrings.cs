using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStacksQueuesAndBags
{
    class DynamicCountArrayQueueOfStrings
    {
        private string[] array = null;
        private int Head = 0;
        private int Tail = 0;

        public DynamicCountArrayQueueOfStrings()
        {
            array = new string[1];
        }

        public bool IsEmpty()
        {
            return Head == 0;
        }

        public void Enqueue(string str)
        {
            if (array.Length == Tail)
            {
                ResizeArray(2 * array.Length);
            }

            array[Tail++] = str;
        }

        //Avoid Loitering, so that garbage collector can reclaim the memory.
        public string Dequeue()
        {
            if (Tail <= 0)
            {
                return "No item to pop";
            }

            string itemToDelete = array[Head];
            array[Head++] = null;

            if (Tail > 0 && (Tail - Head) == array.Length / 4) ////Avoid thrashing by refreshing when array is quarter full instead of half.
            {
                ResizeArray(array.Length / 2);
            }

            return itemToDelete;
        }

        public int Size()
        {
            return Tail;
        }

        private void ResizeArray(int capacity)
        {
            string[] newArray = new string[capacity];
            int diff = Tail - Head;
            for (int i = 0; i < diff; i++)
            {
                newArray[i] = array[Head + i];
            }

            Head = 0;
            Tail = diff;
            array = newArray;
        }
    }
}
