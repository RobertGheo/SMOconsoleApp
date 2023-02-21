using SMOconsoleApp.MenuOptions;

namespace SMOconsoleApp
{
    internal class Program
    {
        public static string inputString;
        static void Main(string[] args)
        {            
            bool checkString = false;
            //char selectInt;
            Console.WriteLine("<<< Welcome to the String manipulation program >>>");

            DisplayMenu();
            AskUserString();

            while (checkString == false)
            {   try
                {
                    Console.Write("\nSelect a menu option: ");
                    string inputMenu = Console.ReadLine().Trim().ToLower();
                    switch (inputMenu)
                    {
                        case "a":
                            Console.WriteLine("\n>>>\t {0}", OptionsA.UpperCase(inputString));
                            break;
                        case "b":                           
                            Console.WriteLine("\n>>>\t {0}", OptionsB.Reverse1(inputString));
                            break;
                        case "c":
                            Console.WriteLine("\n>>>\t {0} vowels", OptionsC.VowelsStr(inputString));
                            break;
                        case "d":
                            Console.WriteLine("\n>>>\t {0} words", OptionsD.CountWords(inputString));
                            break;
                        case "e":
                            Console.WriteLine("\n>>>\t {0}", OptionsE.TitleCase(inputString));
                            break;
                        case "f":
                            Console.WriteLine("\n>>>\t '{0}' {1}",inputString, OptionsF.PalindromeC(inputString));
                            break;
                        case "g":                           
                            OptionsG.MinMaxWord(inputString);
                            break;
                        case "h":
                            OptionsH.MostUsedWord(inputString);
                            break;
                        case "n":
                            Console.Clear();
                            DisplayMenu();
                            AskUserString();
                            break;
                        case "q":
                            Console.WriteLine();
                            Console.Write("Do you want to exit the program Y/N:");
                            char askExit = Convert.ToChar(Console.ReadLine().Trim().ToLower());
                            if (askExit == 'y') { checkString = true; }
                            Console.Clear();
                            DisplayMenu();
                            break;
                        default:
                            Console.WriteLine("\tWrong input, plese insert a menu option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("No empty menu input is allowed!" + e.Message);
                    
                }
                /*
                if (char.TryParse(inputMenu, out selectInt) || selectInt == 'q')
                {

                    Console.WriteLine("Your input is {0} ", inputMenu);
                }
                else if (!char.TryParse(inputMenu, out selectInt) || selectInt < 'a' || selectInt > 'e') 
                {

                }
                else
                {
                    Console.WriteLine("Your input is {0} ", inputMenu);
                }*/

            }
            //Console.ReadKey();
            Console.Clear();
        }

        public static void AskUserString()
        {
            bool checkLength = false;
            while (checkLength == false)
            {
                Console.WriteLine("\nPlease insert a String: ");
                inputString = Console.ReadLine().Trim();
                if (inputString.Length <= 1)
                {
                    Console.Clear();
                    DisplayMenu();
                    Console.WriteLine("\n*** You have to insert a string greater than 1 char ***");
                    checkLength = false;                   
                    
                } 
                else
                {
                    Console.Clear();
                    DisplayMenu();
                    Console.WriteLine("\nYour string is: \n{0}", inputString);
                    checkLength = true;
                }
                
            }
        }
        public static void DisplayMenu()
        {            
            Console.WriteLine("\n\r\t a. Convert the string to uppercase");
            Console.WriteLine("\n\r\t b. Reverse the string");
            Console.WriteLine("\n\r\t c. Count the number of vowels in the string");
            Console.WriteLine("\n\r\t d. Count the number of words in the string");
            Console.WriteLine("\n\r\t e. Convert the string to title case");
            Console.WriteLine("\n\r\t f. Check if the string is a palindrome");
            Console.WriteLine("\n\r\t g. Find the longest and shortest words in the string");
            Console.WriteLine("\n\r\t h. Find the most frequent word in the string");
            Console.WriteLine("\n\r\t i. Perform multiple operation on the sting");
            Console.WriteLine("\n\r\t j. New string operation");
            Console.WriteLine("\n\r\t n. Insert a new string");
            Console.WriteLine("\n\r\t q. Exit program");
            Console.WriteLine("\r\t ============================================");
        }       
    }
}