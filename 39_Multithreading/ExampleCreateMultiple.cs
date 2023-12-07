using System;
using System.Threading;

namespace _39_Multithreading
{
    public class ExampleCreateMultiple
    {
        public void Run()
        {
            Console.WriteLine("In Main Thread: Creating the Child thread\n\n");

            ThreadStart threadStart = new ThreadStart(ThreadFunction);

            for(int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(threadStart);
                thread.Name = "Thread # : " + i;
                thread.Start();

                Thread.Sleep(5 * 1000);
            }

            Console.ReadKey();
        }

        // This function will run on separate thread
        public void ThreadFunction()
        {
            Console.WriteLine("I am running on Child Thread");
            Console.WriteLine("My name is " + Thread.CurrentThread.Name);
        }
    }
}
