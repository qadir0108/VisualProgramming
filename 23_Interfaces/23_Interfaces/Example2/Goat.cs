using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Interfaces.Example2
{
    public class Goat : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The Goat says: baah baah.");
        }

        public void run()
        {
            Console.WriteLine("The Goat runs fast.");
        }

    }
}
