using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringBuilderEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a new StringBulider
            StringBuilder builder = new StringBuilder();
            builder.Append("The list starts here:");
            builder.AppendLine();
            builder.Append("1 cat").AppendLine();
            builder.Append("2 dog").AppendLine();
            builder.Append("3 bird").AppendLine();

            //Get a reference to the stringBuilder's buffer content.
            string innerString = builder.ToString();

            //Display
            Console.WriteLine(innerString);
            Console.ReadKey();
        }
    }
}
