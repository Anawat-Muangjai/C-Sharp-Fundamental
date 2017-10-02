using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TryCatchException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = null;
                ProcessString(s);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("{0} First Exception caught.", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Second Exception caught", e);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static void ProcessString(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
