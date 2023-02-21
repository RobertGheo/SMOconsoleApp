using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsD
    {
        public static int CountWords(string inputString)
        {
            int wordsCount = 0, wordsTotal = 1;
            while (wordsCount <= inputString.Length-1)
            {
                if (inputString[wordsCount] == ' ' ||                   
                    inputString[wordsCount] == '\n' ||
                    inputString[wordsCount] == '\t')
                {
                    if (inputString[wordsCount + 1] == ' ' ||
                        inputString[wordsCount + 1] == '\n' ||
                        inputString[wordsCount + 1] == '\t')
                    {
                        //Console.WriteLine("Skip");
                    }
                    else
                    {
                        wordsTotal++;
                    }
                }
                wordsCount++;               
            }

            Console.WriteLine("\nThe result for option D:");
            return wordsTotal;
        }
        public static int CountWordsB(string inputString)
        {
            int wordsTotal = 0;

            for (int i =0; i < inputString.Length - 1; i++ )
            {
                if (inputString[i] == ' ' ||
                    inputString[i] == '\n' ||
                    inputString[i] == '\t' )
                {
                    if (inputString[i + 1] == ' ' ||
                        inputString[i + 1] == '\n' ||
                        inputString[i + 1] == '\t')
                    {
                        //Console.WriteLine("Skip");
                    }                  
                    else
                    {
                        wordsTotal++;
                    }                                        
                }               
            }
            wordsTotal++;

            Console.WriteLine("\nThe result for option D:");
            return wordsTotal;
        }
    }
}
