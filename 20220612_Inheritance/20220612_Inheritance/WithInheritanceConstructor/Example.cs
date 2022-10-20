using System;

namespace _20220612_Inheritance.WithInheritanceConstructor
{
    public class Example
    {
        public void Run()
        {
            //Console.WriteLine("=========================================");
            //Console.WriteLine("=====Inheritance Constructor Call========");
            //Console.WriteLine("=========================================");

            //Person person = new Person("CNIC-123", "Person Name");
            //person.Show();

            //Student student = new Student("CNIC-123", "Student123", 123, 500);
            //Console.WriteLine("Student Data");
            //student.Show();

            //Console.WriteLine("=========================================");
            //Teacher teacher = new Teacher("CNIC-321", "Teacher321", 321, "Coding");
            //Console.WriteLine("Teacher Data");
            //teacher.Show();

            /*
             * We can save it in Person type
             * - set Parent class show function as *virtual*
             * - change Child class show function as *override*
            */
            Person p1 = new Student("CNIC-123", "Student123", 123, 500);
            p1.Show();

            Person p2 = new Teacher("CNIC-321", "Teacher321", 321, "Coding");
            p2.Show();
        }
    }
}
