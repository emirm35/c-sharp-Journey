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

           

            string writeText = Console.ReadLine(); // Girilen yazıları writeText değişkenine ata
            File.WriteAllText("filename.txt", writeText); // filename.txt adlı text dosyasına writeText değişkenini bas

           














            Console.ReadKey();

        }
    }
}
