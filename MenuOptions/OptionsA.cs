using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsA
    {
        public static string UpperCase(string upperString)
        {
            upperString = upperString.ToUpper();
            Console.Clear();
            Program.DisplayMenu();
            Console.WriteLine("\nThe result for option A:");
            return upperString;
        }

    }
}
