using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp.MenuOptions
{
    internal class OptionsA
    {
        //method to transform the input string in Upper Case
        // first method a easy one 
        public static string UpperCase(string upperString)
        {
            upperString = upperString.ToUpper();           
            Console.WriteLine("\nThe result for option A:");
            return upperString;
        }

        //second method created to use for loop to implement the Upper Case task
        public static string UpperCaseB(string upperString)
        {
            string sInput = upperString;            //save the user input into a new string variable
            char[] charArray = sInput.ToCharArray();    //convert the new string variable in to a char array

            Console.WriteLine("\nThe result for option A:");
            string resultS = "";
            //run the for loop for each char of the user input
            //and convert each char in Upper Case and store in a string variable
            for (int i = 0; i < charArray.Length; i++)
            {
                resultS += (charArray[i].ToString().ToUpper());
            }          

            return resultS;
        }

    }
}
