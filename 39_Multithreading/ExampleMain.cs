using System;
using System.Threading;

namespace _39_Multithreading
{
    public class ExampleMain
    {
        public void Run()
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("I am {0}", th.Name);
            Console.ReadKey();
        }
    }
}
