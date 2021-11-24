using System;

namespace _36_Generics
{
    public class ExampleGenericArray
    {
        public void Run()
        {
            /* declaring an int array */
            GenericArray<int> intArray = new GenericArray<int>(5);

            //setting values
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }

            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }
            Console.WriteLine();


            /* declaring an character array */
            GenericArray<char> charArray = new GenericArray<char>(5);
            //setting values
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }

            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }

            Console.WriteLine();
            Console.ReadKey();

        }

    }
}
