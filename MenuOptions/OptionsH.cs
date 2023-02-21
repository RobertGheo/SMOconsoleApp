using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsH
    {
        //the method to find mpst used word in a string
        public static void MostUsedWord(string inputString)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string sInput = inputString.ToLower();
            sInput = sInput.Replace(",", ""); 
            sInput = sInput.Replace(".", ""); 
            string[] arr = sInput.Split(' '); 

            //here the words are saved in a dictionary
            foreach (string word in arr) 
            {
                if (word.Length >= 2) 
                {
                    if (dictionary.ContainsKey(word)) 
                        dictionary[word] = dictionary[word] + 1;
                        
                    else
                        dictionary[word] = 1; 
                }
            }
            int tempTimes = 0;
            string tempString = "";

            //here the loop is runing to find the most used word stored in dictionary 
            foreach (KeyValuePair<string, int> pair in dictionary) 
            {                
                if (tempTimes <= pair.Value)
                {
                    tempTimes = pair.Value;
                    tempString = pair.Key;
                }               
            } 

            Console.WriteLine("\nThe result for option H:");            
            Console.WriteLine("\n>>>\t '{0}' is most frequent word, used '{1}' times", tempString, tempTimes);           
        }

    }
}
