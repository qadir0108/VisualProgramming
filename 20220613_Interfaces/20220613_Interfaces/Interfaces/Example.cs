using System;

namespace _20220613_Interfaces.Interfaces
{
    public class Example
    {
        public void Run()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("============= Interfaces ================");
            Console.WriteLine("=========================================");

            // TeachingAssistant object can be saved in ITeachingAssistant or TeachingAssistant
            ITeachingAssistant person1 = new TeachingAssistant("CNIC-111", "Teaching Assistant 111", "Junior");
            person1.Show();

            TeachingAssistant person2 = new TeachingAssistant("CNIC-222", "Teaching Assistant 222", "Senior");
            person2.Show();

            // OR TeachingAssistant object can be saved in
            // even generic interface IPerson or parent class Person
            IPerson person3 = new TeachingAssistant("CNIC-333", "Teaching Assistant 333", "Junior");
            person3.Show();

            Person person4 = new TeachingAssistant("CNIC-444", "Teaching Assistant 444", "Senior");
            person4.Show();

            // Interface MAGIC is this
            Process(person1);
            Process(person3);
        }

        // Receive in child interface
        void Process(ITeachingAssistant person)
        {
        }

        // Receive in parent interface
        void Process(IPerson person)
        {
        }
    }
}
