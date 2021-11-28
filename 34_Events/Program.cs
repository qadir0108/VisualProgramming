using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Events
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ExampleEvent exampleEvent = new ExampleEvent();
            exampleEvent.Run();

            //ExampleForm exampleForm = new ExampleForm();
            //System.Windows.Forms.Application.Run(exampleForm);
        }
    }
}
