using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _123
{ 

    internal class Program
    {





        static void Main(string[] args)
        {

           






            string writeText = "Hello world"; //Create a text string 
            File.WriteAllText("filename.txt", writeText); // Create a file and write the contents of writetext to it

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);















            Console.ReadKey();

        }
    }
}
