using System;
using System.Collections;

namespace _35_Collections
{
    public class ExampleStack
    {
        public void Run()
        {
            Stack st = new Stack();
            st.Push('A');
            st.Push('B');
            st.Push('C');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('D');
            st.Push('E');

            Console.WriteLine("The next poppable value in stack: {0}",st.Peek());

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Removing values ");
            
            st.Pop();
            st.Pop();
            st.Pop();
            
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }
}
