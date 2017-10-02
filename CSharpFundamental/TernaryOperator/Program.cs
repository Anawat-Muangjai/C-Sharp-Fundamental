using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetValue("Sam"));
            Console.WriteLine(GetValue("Jane"));
            Console.ReadKey();
        }

        static int GetValue(string name)
        {
            //Replace if by ? (TernaryOperator)
            return name == "Sam" ? 100 : -1;
        }
    }
}
