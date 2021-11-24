using System;
using System.Threading;

namespace _39_Multithreading
{
    public class ExampleCreate
    {
        public void Run()
        {
            Console.WriteLine("In Main Thread: Creating the Child thread\n\n");

            ThreadStart threadStart = new ThreadStart(ThreadFunction);
            Thread thread = new Thread(threadStart);
            thread.Name = "Thread # 1";
            thread.Start();
            
            Console.ReadKey();
        }

        // This function will run on separate thread
        public static void ThreadFunction()
        {
            Console.WriteLine("I am running on Child Thread");

            Console.WriteLine("My name is " + Thread.CurrentThread.Name);
        }
    }
}
