using _23_Interfaces.Example1;
using _23_Interfaces.Example2;
using _23_Interfaces.Example3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleTransaction exampleTransaction = new ExampleTransaction();
            exampleTransaction.Run();

            //ExampleGoat exampleGoat = new ExampleGoat();
            //exampleGoat.Run();

            //DemoClass myObj = new DemoClass();
            //myObj.Run();

        }
    }
}
