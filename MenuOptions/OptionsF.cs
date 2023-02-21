using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsF
    {
        public static bool Palindrome(string inputUser)
        {
            string insertStr = inputUser.ToLower();
            char[] reverseStr = insertStr.ToCharArray();           
            Array.Reverse(reverseStr);

            Console.WriteLine("\nThe result for option F:");
            return new string(reverseStr).Equals(insertStr);
        }

        public static string PalindromeB(string inputUser)
        {
            string reverseStr = string.Empty;
            string insertStr = inputUser.ToLower();
            string resultPal;

            for (int i = insertStr.Length - 1; i>=0; i--)
            {
                reverseStr += insertStr[i].ToString();
            }
            if (reverseStr == insertStr)
            {
                resultPal = "is Palindrome";
            }
            else
            {
                resultPal = "is not Palindrome";
            }

            Console.WriteLine("\nThe result for option F:");
            return  resultPal;
        }

        public static string PalindromeC(string inputUser)
        {
            string insertStr = inputUser.ToLower();
            char[] reverseStr = insertStr.ToCharArray();
            string resultPal;

            Array.Reverse(reverseStr);

            if (new string(reverseStr).Equals(insertStr))
            {
                resultPal = "is a Palindrome";
            }
            else
            {
                resultPal = "is not Palindrome";
            }

            Console.WriteLine("\nThe result for option F:");
            return resultPal;
        }

    }
}
