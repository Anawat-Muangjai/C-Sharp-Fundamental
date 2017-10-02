using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car
            {
                Make = "Honda",
                Model = "City",
                Year = "2009"
            };

            var car2 = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = "2020"
            };

            //string isEqual = car.Equals(car2) ? "Yes, equal.": "No, not equal";

            string engine = car.Start();

            Console.WriteLine(car.Make + car.Model + " is " + engine);
            //Console.WriteLine(isEqual);
            Console.ReadKey();
        }
    }
}
