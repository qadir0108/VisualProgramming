using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Delegates
{
    public class ExampleDelegateUsage
    {
        // delegate declaration
        public delegate void printString(string s);

        static FileStream fs;
        static StreamWriter sw;


        // this method prints to the console
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        //this method prints to a file
        public static void WriteToFile(string s)
        {
            fs = new FileStream("message.txt",
            FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        // this method takes the delegate as parameter and uses it to
        // call the methods as required
        public static void sendString(printString ps)
        {
            ps("Hello World");
        }

        public void Run()
        {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
            Console.ReadKey();
        }

    }
}
