

/// C# - Collection - SortedList Class
/// 

using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add("001", "Jeevan Kumar");
            sl.Add("002", "Apsara Ramteke");
            sl.Add("003", "Jasmine Kiwale");
            sl.Add("004", "Nilesh Katkar");
            //sl.Add("005", "M. Kale");
            sl.Add("006", "M. Kedari");
            sl.Add("007", "Ritesh Sable");

            if (sl.ContainsValue("M. Kale"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("008", "M. Kale");
            }

            // get a collection of the keys. 
            ICollection key = sl.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
        }
    }
}