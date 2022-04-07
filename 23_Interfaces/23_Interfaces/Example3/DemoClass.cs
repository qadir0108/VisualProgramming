using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Interfaces.Example3
{
    /// <summary>
    /// Source : https://www.w3schools.com/cs/cs_interface.php
    /// </summary>
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void Run()
        {
            myMethod();
            myOtherMethod();

            Console.ReadKey();
        }

        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }

    }
}
