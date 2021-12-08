using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Strings
{
    public class ExampleSubstring
    {
        public void Run()
        {
            string str = "Welcome to BS(IT)";
            Console.WriteLine(str);

            string substr = str.Substring(11);
            Console.WriteLine(substr);

            Console.ReadKey();
        }
    }
}
