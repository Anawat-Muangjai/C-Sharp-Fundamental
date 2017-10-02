using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var textToTest = "anawat.mu@outlook.com";
            var regularExpression = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            var result = Regex.IsMatch(textToTest, regularExpression, RegexOptions.None);
            if (result)
            {
                Console.WriteLine("Text matched expression");
            }
            Console.ReadKey();
        }
    }
}
