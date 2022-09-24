using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{

     


    internal class Program
    {
         
      

        static void Main(string[] args)
        {
           
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            Console.WriteLine(myCar.brand + " " + myCar.modelName);












            Console.ReadKey();

        }
    }
}
