using System;

namespace _20220613_Interfaces.Interfaces
{
    public class Person : IPerson
    {
        public String CNIC { get; set; }
        public String Name { get; set; }

        public Person(string cNIC, string name)
        {
            CNIC = cNIC;
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("CNIC: \t\t" + CNIC);
            Console.WriteLine("Name: \t\t" + Name);
        }

        public void Register()
        {
            throw new NotImplementedException();
        }
    }

    public class Student : Person, IStudent
    {
        public int RollNumber { get; set; }
        public int Marks { get; set; }

        public Student(string cNIC, string name, int rollNumber, int marks) : base(cNIC, name)
        {
            RollNumber = rollNumber;
            Marks = marks;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Roll Number: \t" + RollNumber);
            Console.WriteLine("Marks: \t\t" + Marks);
        }

        public void Studies()
        {
            throw new NotImplementedException();
        }
    }

    public class Teacher : Person, ITeacher
    {
        public int EmployeeCode { get; set; }
        public String Subject { get; set; }

        public Teacher(string cNIC, string name, int employeeCode, string subject) : base(cNIC, name)
        {
            EmployeeCode = employeeCode;
            Subject = subject;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Employee Code: \t" + EmployeeCode);
            Console.WriteLine("Subject: \t" + Subject);
        }

        public void Teaches()
        {
            throw new NotImplementedException();
        }
    }

    public class TeachingAssistant : Person, ITeachingAssistant
    {
        public String Level { get; set; }

        public TeachingAssistant(string cNIC, string name, string level) : base(cNIC, name)
        {
            Level = level;
        }

        public override void Show()
        {
            Console.WriteLine("Teaching Assistant Data");
            base.Show();
            Console.WriteLine("Level: \t\t" + Level);
        }

        public void Studies()
        {
            throw new NotImplementedException();
        }

        public void Teaches()
        {
            throw new NotImplementedException();
        }

        public void MarksAssignments()
        {
            throw new NotImplementedException();
        }
    }
}
