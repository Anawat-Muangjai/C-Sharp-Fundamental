using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            string str1, str2;
            Method(out value, out str1, out str2);
            Console.WriteLine("value = {0}, str1 = {1}, str2 = {2}", value, str1, str2);
            Console.ReadKey();
        }

        static void Method(out int i, out string s1, out string s2)
        {
            i = 44;
            s1 = "I've been returned";
            s2 = null;
        }
    }
}
