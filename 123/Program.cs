using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{ 


  
    enum Levels
    {
        zor
    }
        





    internal class Program
    {









        enum Level
        {
            Low = 5,
            Medimum = 10,
            High = 15
        }












        static void Main(string[] args)
        {
            Level myVar = Level.High;

            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                    case Level.Medimum:
                    Console.WriteLine("Medium level");
                    break ;
                    case Level.High:
                    Console.WriteLine("High level");
                    break;
            }


            Console.ReadKey();

        }
    }
}
