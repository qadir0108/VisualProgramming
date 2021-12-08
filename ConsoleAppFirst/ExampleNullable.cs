using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    public class ExampleNullable
    {
        public void Run()
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();
            
            // display the values
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);

            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            
            Console.ReadLine();
        }

        public void Run2()
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;

            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);

            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);

            Console.ReadLine();
        }
    }
}
