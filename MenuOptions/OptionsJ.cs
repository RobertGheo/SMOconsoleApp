using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsJ
    {
     
        public static void NewOperation(string inputString)
        {                       
            string sInput = inputString.ToLower();
            sInput = sInput.Replace(",", "");
            sInput = sInput.Replace(".", "");
            sInput = sInput.Replace(" ", "");
            char[] charArray = sInput.ToCharArray();

            Console.WriteLine("\nThe result for option J:");
            Console.Write("\n>>>\t");

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write(charArray[i].ToString().ToUpper());
                Console.Write(charArray[i].ToString().ToLower() + " ");
                Thread.Sleep(50);
            }
            Console.WriteLine("\n");

            Console.Write("\n>>>\t");
            for (int i = 0; i< charArray.Length; i++)
            {
                if (charArray[i] == 'a' ||
                    charArray[i] == 'e' ||
                    charArray[i] == 'i' ||
                    charArray[i] == 'o' ||
                    charArray[i] == 'u')
                {
                    Console.Write(charArray[i].ToString().ToUpper());
                    Console.Write(charArray[i].ToString().ToLower() + " ");
                    Thread.Sleep(50);
                }               
            }
            Console.WriteLine("\n");
        } 

    }
}
