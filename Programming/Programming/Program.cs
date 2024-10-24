using System;

namespace Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Visual Programming");

            // 1. Variables
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Name:" + name + "\tMarks:" + marks);

            // 2. Conditions
            if (marks >= 50)
                Console.WriteLine(name + " is PASS");
            else
                Console.WriteLine(name + " is FAIL");

            // 3. Loops
            for (int i = 0; i < 5; i++)
                Console.WriteLine(name);

            // 4. Arrays
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Total Marks: " + sum + " out of 500");

            // 5. Functions
            int result = add(10, 5);
            Console.WriteLine(result);

            // 6. Objects
            Calculator obj = new Calculator();
            int x = obj.add(10, 5);
            obj.print(x);

            Console.ReadLine();
        }

        public static int add(int a, int b)
        {
            return a + b;
        }
    }
}