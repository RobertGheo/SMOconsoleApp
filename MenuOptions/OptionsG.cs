using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsG
    {
        static string minWord = "", maxWord = "";
        public static void MinMaxWord(string inputS)
        {         
            int lengthString = inputS.Length;
            int firstCharString = 0, lastCharString = 0;
            int minLength = lengthString, minStartIndex = 0;
            int maxLength = 0, maxStartIndex = 0;

            while (firstCharString <=lengthString)
            {
                if (firstCharString < lengthString && inputS[firstCharString] != ' ')
                {
                    firstCharString++;
                }
                else
                {
                    int tempLength = firstCharString - lastCharString;

                    if (tempLength < minLength)
                    {
                        minLength = tempLength;
                        minStartIndex = lastCharString;
                    }

                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        maxStartIndex = lastCharString;
                    }
                    firstCharString++;
                    lastCharString = firstCharString;
                }
            }
            
            minWord = inputS.Substring(minStartIndex, minLength);
            maxWord = inputS.Substring(maxStartIndex, maxLength);
            
            Console.WriteLine("\nThe result for option G:");
            Console.WriteLine("Your string: '{0}'", inputS);
            Console.WriteLine("\n>>>\t Longest word: '{0}'", maxWord);
            Console.WriteLine("\n>>>\t Shortest word: '{0}'", minWord);
        }
    }
}
