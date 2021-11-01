using System;
using System.IO;

namespace FileIO
{
    public class ExampleStreamWriter
    {
        public void Run()
        {
            string[] names = new string[] { "Zara Ali", "Nuha Ali" };
            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }
            
            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
