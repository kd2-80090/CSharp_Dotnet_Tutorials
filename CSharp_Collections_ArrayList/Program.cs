


/// C# - ArrayList Class
/// 

using System;
using System.Collections;

namespace CollectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            list.Add(45);
            list.Add(78);
            list.Add(33);
            list.Add(56);
            list.Add(12);
            list.Add(23);
            list.Add(9);

            Console.WriteLine("Capacity: {0} ", list.Capacity);
            Console.WriteLine("Count: {0}", list.Count);

            Console.Write("Content: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            list.Sort();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

