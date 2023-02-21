using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsB
    {
        //first method to revers a string
        public static string Reverse1(string reverse)
        {
            char[] charArray = reverse.ToCharArray();
            Array.Reverse(charArray);
            Console.Clear();
            Program.DisplayMenu();
            Console.WriteLine("\nThe result for option B:");
            return new string(charArray);
        }

        //second method to revers a string
        public static string Reverse2(string reverse)
        {
            char[] charArray = reverse.ToCharArray();
            string reverseStr = String.Empty;

            for (int i = charArray.Length -1; i> -1; i--)
            {
                reverseStr += charArray[i];
            }
            Console.Clear();
            Program.DisplayMenu();
            Console.WriteLine("\nThe result for option B1:");
            return reverseStr;
        }

    }
}
