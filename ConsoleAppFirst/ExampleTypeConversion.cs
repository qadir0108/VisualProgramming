using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    public class ExampleTypeConversion
    {
        public void Run()
        {
            Console.WriteLine("Calling DoubleToInt");
            DoubleToInt();

            Console.WriteLine("Calling VariableToString");
            VariableToString();
            
            Console.ReadKey();

        }

        public void DoubleToInt()
        {
            double d = 5673.74;
            int i;
            // cast double to int.
            i = (int)d;
            Console.WriteLine(i);
        }

        public void VariableToString()
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
        }
    }
}
