﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsC
    {
        public static int VowelsStr(string vowelString)
        {
            int totalVowel = 0;
            string vowelLower = vowelString.ToLower();
            for (int i = 0; i< vowelLower.Length; i++)
            {
                if (vowelLower[i] == 'a' || 
                    vowelLower[i] == 'e' ||
                    vowelLower[i] == 'i' || 
                    vowelLower[i] == 'o' ||
                    vowelLower[i] == 'u')
                {
                    totalVowel++;
                }
            }
            Console.Clear();
            Program.DisplayMenu();
            Console.WriteLine("\nThe result for option C:");
            return totalVowel;
        }
        public static int VowelsStrB(string vowelString)
        {
            int totalVowel = 0;
            string vowelLower = vowelString.ToLower();
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u'};

            for (int i = 0; i < vowelLower.Length; i++)
            {
                if (vowels.Contains(vowelLower[i]))
                {
                    totalVowel++;
                }
            }
            Console.Clear();
            Program.DisplayMenu();
            Console.WriteLine("\nThe result for option A:");
            return totalVowel;
        }

    }
}
