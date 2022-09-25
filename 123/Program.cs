using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{

    interface IFirstInterface
    {
        void myMethod();
    }
    interface ISecondInterface
    {
        void myOtherMethod();
    }


     class DemoClass : IFirstInterface,ISecondInterface
    {

        public void myMethod()
        {
        Console.WriteLine("Some text");

        }

        public void myOtherMethod()
        {
        Console.WriteLine("Some other text");
        }





    }


    enum level
    {
        Low,
        Medium,
        High
    }









    internal class Program
    { 


        static void Main(string[] args)
        {
           DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();

            level myVar = level.Medium;
            Console.WriteLine(myVar);
           




            Console.ReadKey();
        }
    }
}
