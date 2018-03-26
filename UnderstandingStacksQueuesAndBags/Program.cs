using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStacksQueuesAndBags
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListStacksOfStrings sos = new LinkedListStacksOfStrings();
            //string input = Console.ReadLine();
            //while (!string.IsNullOrWhiteSpace(input))
            //{
            //    if (!input.Equals("-"))
            //    {
            //        sos.Push(input);
            //    }
            //    else
            //    {
            //        Console.WriteLine(sos.Pop());
            //    }
            //    input = Console.ReadLine();
            //}

            //FixedCapacityStackOfStrings sos = new FixedCapacityStackOfStrings(10);
            //string input = Console.ReadLine();
            //while (!string.IsNullOrWhiteSpace(input))
            //{
            //    if (!input.Equals("-"))
            //    {
            //        sos.Push(input);
            //    }
            //    else
            //    {
            //        Console.WriteLine(sos.Pop());
            //    }
            //    input = Console.ReadLine();
            //}

            //DynamicCountArracyStackOfStrings sos = new DynamicCountArracyStackOfStrings();
            //string input = Console.ReadLine();
            //while (!string.IsNullOrWhiteSpace(input))
            //{
            //    if (!input.Equals("-"))
            //    {
            //        sos.Push(input);
            //    }
            //    else
            //    {
            //        Console.WriteLine(sos.Pop());
            //    }
            //    input = Console.ReadLine();
            //}

            //LinkedListQueueOfStrings sos = new LinkedListQueueOfStrings();
            //string input = Console.ReadLine();
            //while (!string.IsNullOrWhiteSpace(input))
            //{
            //    if (!input.Equals("-"))
            //    {
            //        sos.Push(input);
            //    }
            //    else
            //    {
            //        Console.WriteLine(sos.Pop());
            //    }
            //    input = Console.ReadLine();
            //}


            DynamicCountArrayQueueOfStrings sos = new DynamicCountArrayQueueOfStrings();
            string input = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(input))
            {
                if (!input.Equals("-"))
                {
                    sos.Enqueue(input);
                }
                else
                {
                    Console.WriteLine(sos.Dequeue());
                }
                input = Console.ReadLine();
            }

            Console.Read();
        }
    }
}
