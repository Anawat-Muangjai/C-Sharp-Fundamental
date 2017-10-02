using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Foo(99);
            Foo("text");
            Console.ReadKey();
        }

        static void Foo(int x)
        {
            Console.WriteLine("Foo(int x)");
        }

        static void Foo(string y)
        {
            Console.WriteLine("Foo(String y)");
        }
    }
}
