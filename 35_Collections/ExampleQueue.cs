using System;
using System.Collections;

namespace _35_Collections
{
    public class ExampleQueue
    {
        public void Run()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            Console.WriteLine("Current queue: ");
            foreach (int c in q)
                Console.Write(c + " ");
            Console.WriteLine();
            
            q.Enqueue(50);
            q.Enqueue(60);
            Console.WriteLine("Current queue: ");
            foreach (int c in q)
                Console.Write(c + " ");

            Console.WriteLine();
            Console.WriteLine("Removing some values ");

            int ch = (int)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            ch = (int)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            Console.ReadKey();
        }
    }
}
