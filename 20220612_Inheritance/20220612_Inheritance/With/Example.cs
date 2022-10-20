using System;

namespace _20220612_Inheritance.With
{
    public class Example
    {
        public void Run()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("=======Inheritance Function Call=========");
            Console.WriteLine("=========================================");
            // Creating Parent class object and saving in Parent type variable
            Person person = new Person();
            // It will call Parent class Show
            person.Show();

            Console.WriteLine("=========================================");
            // Creating Child class object
            Student student = new Student();
            // It will call Child class Student Show
            student.Show();

            Console.WriteLine("=========================================");
            // Creating Child class object
            Teacher teacher = new Teacher();
            // It will call Child class Teacher Show
            teacher.Show();
        }
    }
}
