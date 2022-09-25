using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived Class (inherit from Animal)
       class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says:wee wee");
        }
    }



     







    
}
