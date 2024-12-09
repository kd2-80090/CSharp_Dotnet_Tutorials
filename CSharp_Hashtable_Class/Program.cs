

/// C# - Collection - Hashtable Class
/// 

using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "Jeevan Kumar");
            ht.Add("002", "Apsara Ramteke");
            ht.Add("003", "Jasmine Kiwale");
            ht.Add("004", "Nilesh Katkar");
            ht.Add("005", "M. Kale");
            ht.Add("006", "M. Kedari");
            ht.Add("007", "Ritesh Sable");

            if (ht.ContainsValue("Shivam Kale"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Shivam Kale");
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }
    }
}