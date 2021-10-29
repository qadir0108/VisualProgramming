using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExampleFileStream exampleFileStream = new ExampleFileStream();
            //exampleFileStream.Run();

            //ExampleStreamReader exampleStreamReader = new ExampleStreamReader();
            //exampleStreamReader.Run();

            //ExampleStreamWriter exampleStreamWriter = new ExampleStreamWriter();
            //exampleStreamWriter.Run();

            //ExampleBinary exampleBinary = new ExampleBinary();
            //exampleBinary.Run();

            ExampleDirectory exampleDirectory = new ExampleDirectory();
            exampleDirectory.Run();
        }
    }
}
