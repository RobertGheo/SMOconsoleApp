using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsC
    {
        // first method to find vowels from a string
        public static int VowelsStr(string vowelString)
        {
            int totalVowel = 0;
            string vowelLower = vowelString.ToLower();
            for (int i = 0; i< vowelLower.Length; i++) //run a loop through the string length
            {                                          //if a vowel is found is adding to the counting value 
                if (vowelLower[i] == 'a' || 
                    vowelLower[i] == 'e' ||
                    vowelLower[i] == 'i' || 
                    vowelLower[i] == 'o' ||
                    vowelLower[i] == 'u')
                {
                    totalVowel++;                      //adding when a vowel is found
                }
            }
            Console.WriteLine("\nThe result for option C:");
            return totalVowel;
        }
        // second method to find vowels from a string
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
            Console.WriteLine("\nThe result for option C:");
            return totalVowel;
        }

    }
}
