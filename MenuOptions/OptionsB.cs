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
        public static string Reverse(string reverse)
        {
            char[] charArray = reverse.ToCharArray();
            string reverseStr = string.Empty;

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverseStr += charArray[i];
            }
            Console.WriteLine("\nThe result for option B:");
            return reverseStr;
        }

        //second method to revers a string
        public static string ReverseB(string reverse)
        {
            char[] charArray = reverse.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("\nThe result for option B:");
            return new string(charArray);
        }
    }
}
