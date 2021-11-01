using System;
using System.IO;

namespace FileIO
{
    public class ExampleFileStream
    {
        public void Run()
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();

            Console.ReadKey();
        }
    }
}
