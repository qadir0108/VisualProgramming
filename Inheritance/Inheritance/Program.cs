using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //With.Example withExample = new With.Example();
            //withExample.Run();

            WithConstructor.Example withContructorExample = new WithConstructor.Example();
            withContructorExample.Run();

            Console.ReadKey();
        }
    }
}
