using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[,]
{
                {"cat","dog"},
                {"bird","fish"}
};
            Console.WriteLine(array[0, 0]);
            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[1, 0]);
            Console.WriteLine(array[1, 1]);
            Console.ReadKey();
        }
    }
}
