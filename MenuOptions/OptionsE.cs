using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsE
    {
        public static string TitleCase(string inputStr)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            inputStr = textInfo.ToTitleCase(inputStr.ToLower());
           
            Console.WriteLine("\nThe result for option E:");
            return inputStr;
        }

        public static string TitleCaseB(string inputStr)
        {
            string sInput = inputStr.ToLower();            
            char[] charArray = sInput.ToCharArray();

            string storageWord ="";

            for (int i =0 ; i < charArray.Length; i++)
            {
                string tempChar;
                if (i == 0)
                {
                    tempChar = charArray[i].ToString().ToUpper();
                    storageWord += tempChar;                    
                }
                else
                {
                    if (charArray[i] == ' ')
                    {
                        tempChar = charArray[i + 1].ToString().ToUpper();
                        storageWord += " " + tempChar;
                        i++;
                    }
                    else
                    {
                        storageWord += charArray[i];

                    }                  
                }
            }           
            return storageWord;
        }
        public static string TitleCaseC(string inputStr)
        {
            string sInput = inputStr.ToLower();
            char[] charArray = sInput.ToCharArray();
            string storageWord = "";

            int i = 0;
            while (i < charArray.Length)
            {
                string tempChar;
                if (i == 0)
                {
                    tempChar = charArray[i].ToString().ToUpper();
                    storageWord += tempChar;
                    i++;
                }
                else
                {
                    if (charArray[i] == ' ')
                    {
                        tempChar = charArray[i + 1].ToString().ToUpper();
                        storageWord += " " + tempChar;
                        i++;
                    }
                    else
                    {
                        storageWord += charArray[i];
                    }
                    i++;
                }
            }
            return storageWord;
        }

    }
}
