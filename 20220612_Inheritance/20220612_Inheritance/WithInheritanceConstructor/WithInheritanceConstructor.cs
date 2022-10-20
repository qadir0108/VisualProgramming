using System;

namespace _20220612_Inheritance.WithInheritanceConstructor
{
    public class Person
    {
        public String CNIC { get; set; }
        public String Name { get; set; }

        public Person(string cNIC, string name)
        {
            CNIC = cNIC;
            Name = name;
        }

        public void Show()
        {
            Console.WriteLine("CNIC: \t\t" + CNIC);
            Console.WriteLine("Name: \t\t" + Name);
        }
    }

    public class Student : Person
    {
        public int RollNumber { get; set; }
        public int Marks { get; set; }

        public Student(string cNIC, string name, int rollNumber, int marks) : base(cNIC, name)
        {
            RollNumber = rollNumber;
            Marks = marks;
        }

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

        public Teacher(string cNIC, string name, int employeeCode, string subject) : base(cNIC, name)
        {
            EmployeeCode = employeeCode;
            Subject = subject;
        }

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

        public Clerk(string cNIC, string name, string duty) : base(cNIC, name)
        {
            Duty = duty;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine("Duty: \t" + Duty);
        }
    }
}
