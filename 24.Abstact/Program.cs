using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Abstact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vehicle car1 = new vehicle(); //this is not possible as parent class is abstract! to increase security
            Mazda car2 = new Mazda();
            Console.WriteLine(car2.wheels);

            Console.ReadLine();
        }
        abstract class vehicle
        {
            public int wheels =4;
        }
        class Mazda : vehicle
        {

            public int sparewheels = 1;

        }

    }
}
