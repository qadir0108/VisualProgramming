using System;

namespace _36_Generics
{
    public class ExampleGenericFunction
    {
        private void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public void Run()
        {
            int a = 10, b = 20;
            char c = 'I', d = 'V';
            
            //Display values Before Swap:
            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            //Call swap
            Swap<int>(ref a, ref b);
            //Display values after swap:
            Console.WriteLine("\nInt values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);

            //Display values Before Swap:
            Console.WriteLine("\n\nChar values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);
            //Call swap
            Swap<char>(ref c, ref d);
            //Display values after swap:
            Console.WriteLine("\nChar values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);
            Console.ReadKey();

        }

    }
}
