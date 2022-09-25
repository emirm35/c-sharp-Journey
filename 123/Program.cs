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

            try // kodu çalıştırmayı dene
            { 
                int[] sayılar = { 1, 2, 3 };
                Console.WriteLine(sayılar[4]);
            }
            catch (Exception e) // hatayı yakala
            {
                Console.WriteLine(e);
            }
            finally // try catch işlemi bittiğinde her halükarda çalışacak
            {
                Console.WriteLine("İşleminiz sonuçlandı");
            }






















            Console.ReadKey();

        }
    }
}
