using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsI
    {
        //the method is to performe multiple operations on the same string
        public static void MultipleOperations(string inputString)
        {
            Console.WriteLine("Please inser multiple menu options");
            string inputMenu = Console.ReadLine().Trim().ToLower();
            string sInput = inputMenu;
            char[] charArray = sInput.ToCharArray();
            
            Console.WriteLine("\nThe result for option I multiple operations:");

            for (int i = 0; i< charArray.Length; i++)
            {
                if (charArray[i] == 'a')
                    Console.WriteLine("\n>>>\t {0}", OptionsA.UpperCase(inputString));
                if (charArray[i] == 'b')
                    Console.WriteLine("\n>>>\t {0}", OptionsB.Reverse(inputString));
                if (charArray[i] == 'c')
                    Console.WriteLine("\n>>>\t {0} vowels", OptionsC.VowelsStr(inputString));
                if (charArray[i] == 'd')
                    Console.WriteLine("\n>>>\t {0} words", OptionsD.CountWords(inputString));
                if (charArray[i] == 'e')
                    Console.WriteLine("\n>>>\t {0}", OptionsE.TitleCase(inputString));
                if (charArray[i] == 'f')
                    Console.WriteLine("\n>>>\t '{0}' {1}",inputString,OptionsF.PalindromeB(inputString));
                if (charArray[i] == 'g')
                    OptionsG.MinMaxWord(inputString);
                if (charArray[i] == 'h')
                    OptionsH.MostUsedWord(inputString);
                if (charArray[i] == 'j')
                    OptionsJ.NewOperation(inputString);
                if (charArray[i] > 'j')
                {
                    Console.WriteLine("\n*** Please inser only the menu options Letter! ***");
                    break;
                }
            }                       
           
        }

    }
}
