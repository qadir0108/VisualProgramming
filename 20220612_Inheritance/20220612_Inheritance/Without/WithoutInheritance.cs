using System;

namespace _20220612_Inheritance.Without
{
    public class Studuent
    {
        public String CNIC { get; set; }
        public String Name { get; set; }
        public int RollNumber { get; set; }
        public int Marks { get; set; }

        public void Show()
        {
            Console.WriteLine("CNIC: \t" + CNIC);
            Console.WriteLine("Name: \t\t" + Name);
            Console.WriteLine("Roll Number: \t\t" + RollNumber);
            Console.WriteLine("Marks: \t\t" + Marks);
        }
    }

    public class Teacher
    {
        public String CNIC { get; set; }
        public String Name { get; set; }
        public int EmployeeCode { get; set; }
        public String Subject { get; set; }

        public void Show()
        {
            Console.WriteLine("CNIC: \t" + CNIC);
            Console.WriteLine("Name: \t\t" + Name);
            Console.WriteLine("Employee Code: \t\t" + EmployeeCode);
            Console.WriteLine("Subject: \t\t" + Subject);
        }

    }

    public class Clerk
    {
        public String CNIC { get; set; }
        public String Name { get; set; }
        public String Duty { get; set; }

        public void Show()
        {
            Console.WriteLine("CNIC: \t" + CNIC);
            Console.WriteLine("Name: \t\t" + Name);
            Console.WriteLine("Duty: \t\t" + Duty);
        }
    }
}
