using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Polymorphism
{
    public class ExamplePolymorphism
    {
        public void Run()
        {
            //Rectangle r = new Rectangle(10, 7);
            Shape r = new Rectangle(10, 7);

            //Triangle t = new Triangle(10, 5);
            Shape t = new Triangle(10, 5);

            Console.WriteLine("Rectangle Area: {0}", r.area());
            Console.WriteLine("Triangle Area: {0}", t.area());

            Console.ReadKey();
        }

        class Shape
        {
            protected int width, height;
            public Shape(int a = 0, int b = 0)
            {
                width = a;
                height = b;
            }
            public virtual int area()
            {
                Console.WriteLine("Parent class area :");
                return 0;
            }
        }

        class Rectangle : Shape
        {
            public Rectangle(int a = 0, int b = 0) : base(a, b)
            {
            }
            public override int area()
            {
                Console.WriteLine("Rectangle class area :");
                return (width * height);
            }
        }

        class Triangle : Shape
        {
            public Triangle(int a = 0, int b = 0) : base(a, b)
            {
            }
            public override int area()
            {
                Console.WriteLine("Triangle class area :");
                return (width * height / 2);
            }
        }

    }
}
