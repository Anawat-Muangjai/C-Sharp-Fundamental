using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodRefParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 1;
            Method(ref val);
            Console.WriteLine(val);
            Console.ReadKey();
        }

        static void Method(ref int i)
        {
            i = i + 44;
        }
    }
}
