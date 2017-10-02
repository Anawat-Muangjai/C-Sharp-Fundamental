using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
            Method(4);
            Method(4, "Dog");
            Method(name: "Brid");
            Console.ReadKey();
        }

        static void Method(int value = 1, string name = "Peal")
        {
            Console.WriteLine("Value = {0} , Name = {1} ", value, name);
        }
    }
}
