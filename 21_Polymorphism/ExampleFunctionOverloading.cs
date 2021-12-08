using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Polymorphism
{
    public class ExampleFunctionOverloading
    {
        public void Run()
        {
            Printdata p = new Printdata();

            // Call print to print integer
            p.print(5);

            // Call print to print float
            p.print(500.263);

            // Call print to print string
            p.print("Hello C#");

            Console.ReadKey();
        }
    }

    public class Printdata
    {
        public void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        public void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        public void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }
}
