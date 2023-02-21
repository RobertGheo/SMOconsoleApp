using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsE
    {
        public static string TitleCase(string inputStr)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            inputStr = textInfo.ToTitleCase(inputStr.ToLower());
            Console.Clear();
            Program.DisplayMenu();
            Console.WriteLine("\nThe result for option E:");
            return inputStr;
        }

    }
}
