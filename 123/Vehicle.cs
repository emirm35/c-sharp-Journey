﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    public class Vehicle
    {
        public string brand = "ford";
        public void honk()
        {
            Console.WriteLine("düt düüüttt");
        }




    }

    class Car : Vehicle
    {
        public string modelName = "mustang";
    }


}
