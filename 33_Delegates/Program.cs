using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExampleDelegate exampleDelegate = new ExampleDelegate();
            //exampleDelegate.Run();

            //ExampleMulticastDelegate exampleMulticastDelegate = new ExampleMulticastDelegate();
            //exampleMulticastDelegate.Run();

            ExampleDelegateUsage exampleDelegateUsage = new ExampleDelegateUsage();
            exampleDelegateUsage.Run();
        }
    }
}
