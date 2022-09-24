using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
   public class Car
    {
        public string model;
        public string color;
        public int year;
        public int price; 






        public void bilgi(string model, string color,int year,int price)
       {
           Console.WriteLine($"Car model is {this.model} car year is {this.year} and the car color is {this.color} we sell this car for {this.price}TL");
        }










        public Car(string modelName,string modelColor,int modelYear,int modelPrice)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;   
            price = modelPrice;
           bilgi(modelName, modelColor,modelYear,modelPrice);


            
        }
    }
}
