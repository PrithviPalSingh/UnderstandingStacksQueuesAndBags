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
            LinkedListStacksOfStrings<string> sos = new LinkedListStacksOfStrings<string>();
            string input = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(input))
            {
                if (!input.Equals("-"))
                {
                    sos.Push(input);
                }
                else
                {
                    foreach (var item in sos)
                    {
                        Console.WriteLine(item);
                    }
                    //Console.WriteLine(sos.Pop());
                }
                input = Console.ReadLine();
            }

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


            //DynamicCountArrayQueueOfStrings<string> sos = new DynamicCountArrayQueueOfStrings<string>();
            //string input = Console.ReadLine();
            //while (!string.IsNullOrWhiteSpace(input))
            //{
            //    if (!input.Equals("-"))
            //    {
            //        sos.Enqueue(input);
            //    }
            //    else
            //    {
            //        Console.WriteLine(sos.Dequeue());
            //    }
            //    input = Console.ReadLine();
            //}

            Console.Read();
        }
    }
}
