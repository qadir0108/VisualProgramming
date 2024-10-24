﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    public class ExampleEnum
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        public void Run()
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);

            // Real-world Example
            var dt = DateTime.Now;
            if((int)dt.DayOfWeek == (int)Days.thu)
                Console.WriteLine("Today is Programming class " + dt.ToString());

            Console.ReadKey();
        }
    }
}
