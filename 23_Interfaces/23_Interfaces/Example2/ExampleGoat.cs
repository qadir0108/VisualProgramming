using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Interfaces.Example2
{
    /// <summary>
    /// Source : https://www.w3schools.com/cs/cs_interface.php
    /// </summary>
    public class ExampleGoat
    {
        public void Run()
        {
            Goat goat = new Goat();  // Create a Goat object
            goat.animalSound();
            goat.run();

            Console.ReadKey();
        }
    }
}
