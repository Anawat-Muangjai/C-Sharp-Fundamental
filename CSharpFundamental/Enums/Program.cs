using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Sunday;
            int dayNumber = (int)today;

            Console.WriteLine("{0} is day number # {1}.", today, dayNumber);

            Month thisMonth = Month.Jan;
            byte monthNumber = (byte)thisMonth;
            Console.WriteLine("{0} is month number # {1}.", thisMonth, monthNumber);
            Console.ReadKey();
        }
    }
}
