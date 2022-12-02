using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmissionSystem.Data
{
    public class StudentManager
    {
        static List<Student> students = new List<Student>();

        public void Add(long _cnic, string _firstName, string _lastName)
        {
            Student student = new Student();
            student.CNIC = _cnic;
            student.FirstName = _firstName;
            student.LastName = _lastName;
            students.Add(student);
        }

        public List<Student> GetAll()
        {
            return students;
            //{
            //    Debug.WriteLine("CNIC : " + student.CNIC);
            //    Debug.WriteLine("First : " + student.FirstName);
            //    Debug.WriteLine("Last : " + student.LastName);
            //}
        }
    }
}