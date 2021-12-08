using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Strings
{
    public class ExampleContains
    {
        public void Run()
        {
            string str = "Welcome to BS(IT)";
            if (str.Contains("to"))
            {
                Console.WriteLine("String contains 'to'.");
            }
            Console.ReadKey();
        }
    }
}
