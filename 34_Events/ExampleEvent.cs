using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Events
{
    public delegate void EventHandler(string a);

    public class Operation
    {
        public event EventHandler handler;

        public void TriggerEvent(string a)
        {
            if (handler != null)
            {
                handler(a);
            }
            else
            {
                Console.WriteLine("Event Handler Is Not Registered");
            }
        }
    }

    public class ExampleEvent
    {
        public static void CatchEvent(string s)
        {
            Console.WriteLine("Event Caught. Will process accordingly.");
            Console.WriteLine(s);
        }

        public void Run()
        {
            Operation o = new Operation();
            o.handler += new EventHandler(CatchEvent);

            // Event Occurred
            o.TriggerEvent("A new Message!");

            Console.ReadLine();
        }
    }
}
