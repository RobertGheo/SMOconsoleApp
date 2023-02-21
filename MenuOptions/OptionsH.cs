using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsH
    {
        public static void MostUsedWord(string inputString)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string sInput = inputString.ToLower();
            sInput = sInput.Replace(",", ""); 
            sInput = sInput.Replace(".", ""); 
            string[] arr = sInput.Split(' '); 

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
            foreach (KeyValuePair<string, int> pair in dictionary) 
            {
                //Console.WriteLine("Key: {0}, Pair: {1}", pair.Key, pair.Value);   
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
