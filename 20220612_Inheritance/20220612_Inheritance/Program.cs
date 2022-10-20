using System;

namespace _20220612_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //With.Example withExample = new With.Example();
            //withExample.Run();

            WithInheritanceConstructor.Example withContructorExample = new WithInheritanceConstructor.Example();
            withContructorExample.Run();

            Console.ReadKey();
        }
    }
}
