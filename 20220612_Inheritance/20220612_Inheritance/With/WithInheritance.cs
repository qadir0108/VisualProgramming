using System;

namespace _20220612_Inheritance.With
{
    public class Person
    {
        public String CNIC { get; set; }
        public String Name { get; set; }

        public void Show()
        {
            Console.WriteLine("CNIC: \t" + CNIC);
            Console.WriteLine("Name: \t" + Name);
        }
    }

    public class Student : Person
    {
        public int RollNumber { get; set; }
        public int Marks { get; set; }

        public void Show()
        {
            base.Show();
            Console.WriteLine("Roll Number: \t" + RollNumber);
            Console.WriteLine("Marks: \t\t" + Marks);
        }
    }

    public class Teacher : Person
    {
        public int EmployeeCode { get; set; }
        public String Subject { get; set; }

        public void Show()
        {
            base.Show();
            Console.WriteLine("Employee Code: \t" + EmployeeCode);
            Console.WriteLine("Subject: \t" + Subject);
        }

    }

    public class Clerk : Person
    {
        public String Duty { get; set; }

        public void Show()
        {
            base.Show();
            Console.WriteLine("Duty: \t" + Duty);
        }
    }
}
