using _20_Inheritance.Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance
{
    public class ExampleParentChild
    {
        public void Run()
        {
            Rectangle obj = new Rectangle();
            obj.setWidth(5);
            obj.setHeight(7);
            // Print the area of the object.
            Console.WriteLine("Total area: {0}", obj.getArea());
            Console.ReadKey();
        }
    }
}
