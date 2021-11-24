using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExampleMain exampleMain = new ExampleMain();
            //exampleMain.Run();

            //ExampleCreate exampleCreate = new ExampleCreate();
            //exampleCreate.Run();

            //ExampleManage exampleManage = new ExampleManage();
            //exampleManage.Run();

            ExampleDestroy exampleDestroy = new ExampleDestroy();
            exampleDestroy.Run();
        }
    }
}
