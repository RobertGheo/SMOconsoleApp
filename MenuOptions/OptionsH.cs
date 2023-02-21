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
            sInput = sInput.Replace(",", ""); //Just cleaning up a bit
            sInput = sInput.Replace(".", ""); //Just cleaning up a bit
            string[] arr = sInput.Split(' '); //Create an array of words

            foreach (string word in arr) //let's loop over the words
            {
                if (word.Length >= 2) //if it meets our criteria of at least 2 letters
                {
                    if (dictionary.ContainsKey(word)) //if it's in the dictionary
                        dictionary[word] = dictionary[word] + 1; //Increment the count
                        
                    else
                        dictionary[word] = 1; //put it in the dictionary with a count 1
                }
            }
            int tempTimes = 0;
            string tempString = "";
            foreach (KeyValuePair<string, int> pair in dictionary) //loop through the dictionary
            {
                //Console.WriteLine("Key: {0}, Pair: {1}", pair.Key, pair.Value);   
                if (tempTimes <= pair.Value)
                {
                    tempTimes = pair.Value;
                    tempString = pair.Key;
                }               
            } 

            Console.WriteLine("\nThe result for option H:");
            Console.WriteLine("Your string: '{0}'", inputString);
            Console.WriteLine("\n>>>\t '{0}' is most frequent word, used '{1}' times", tempString, tempTimes);           
        }

    }
}
