using System;
using System.Timers;

namespace _33_Delegates
{
    public class ExampleTimer
    {
        public void Run()
        {
            // Create a timer with a two second interval.
            Timer timer = new Timer(2000);
            // Hook up the Elapsed event for the timer. 
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
            Console.ReadKey();
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",e.SignalTime);
        }
    }
}
