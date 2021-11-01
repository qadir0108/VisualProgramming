using System;
using System.Collections;

namespace _35_Collections
{
    public class ExampleSortedList
    {
        public void Run()
        {
            SortedList sl = new SortedList();
            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");
            sl.Add("005", "M. Amlan");
            sl.Add("006", "M. Arif");
            sl.Add("007", "Ritesh Saikia");
            if (sl.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("008", "Nuha Ali");
            }
            // get a collection of the keys.
            ICollection key = sl.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }

            Console.ReadKey();

        }
    }
}
