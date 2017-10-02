using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TryParseConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string numberString = "1234";
            if (int.TryParse(numberString, out number))
            {
                Console.WriteLine("Convertion successed, number now equal " + number);
            }
            else
            {
                Console.WriteLine("Conversion failed, number now equal " + number);
            }
            Console.ReadKey();
        }
    }
}
