﻿using System;
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

        enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6

        }













        static void Main(string[] args)
        {

            int myNum = (int)Months.April;
            Console.WriteLine(myNum);  // 3 


            Console.ReadKey();
        }
    }
}
