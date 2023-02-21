using SMOconsoleApp.MenuOptions;

namespace SMOconsoleApp
{
    internal class Program
    {
        public static string inputString = string.Empty; //is for save the user string and reuse in menu option call
        static void Main(string[] args)
        {            
            bool checkString = false;   //boolean for exit program option         
           
            DisplayBanner.DisplayBannerA();     //a class that display intro of the program
            DisplayMenu();                      // metod called to display the menu options
            AskUserString();                    // metod called to ask users to insert a string

            //use a while loop for repeating the program until the user decide to quit
            while (checkString == false)
            {   // I used try and catch to identify development errors
                try                     
                {
                    Console.Write("\nSelect a menu option: ");
                    string inputMenu = Console.ReadLine().Trim().ToLower();
                    // I used a switch statement for processing user menu input validation 
                    switch (inputMenu)
                    {
                        case "a":
                            ClearDisplayMenu();
                            Console.WriteLine("\n>>>\t {0}", OptionsA.UpperCaseB(inputString)); 
                            break;
                        case "b":
                            ClearDisplayMenu();
                            Console.WriteLine("\n>>>\t {0}", OptionsB.Reverse(inputString));
                            break;
                        case "c":
                            ClearDisplayMenu();
                            Console.WriteLine("\n>>>\t {0} vowels", OptionsC.VowelsStr(inputString));
                            break;
                        case "d":
                            ClearDisplayMenu();
                            Console.WriteLine("\n>>>\t {0} words", OptionsD.CountWords(inputString));
                            break;
                        case "e":
                            ClearDisplayMenu();
                            Console.WriteLine("\n>>>\t {0}", OptionsE.TitleCase(inputString));
                            break;
                        case "f":
                            ClearDisplayMenu();
                            Console.WriteLine("\n>>>\t '{0}' {1}",inputString, OptionsF.PalindromeB(inputString));
                            break;
                        case "g":
                            ClearDisplayMenu();
                            OptionsG.MinMaxWord(inputString);
                            break;
                        case "h":
                            ClearDisplayMenu();
                            OptionsH.MostUsedWord(inputString);
                            break;
                        case "i":
                            ClearDisplayMenu();
                            OptionsI.MultipleOperations(inputString);
                            break;
                        case "j":
                            ClearDisplayMenu();
                            OptionsJ.NewOperation(inputString);
                            break;
                        case "n":
                            ClearDisplayMenu();
                            AskUserString();
                            break;
                        case "q":
                            Console.WriteLine();
                            Console.Write("Do you want to exit the program? Y/N:");
                            char askExit = Convert.ToChar(Console.ReadLine().Trim().ToLower());
                            if (askExit == 'y') { checkString = true; }
                            ClearDisplayMenu();
                            break;
                        default:
                            Console.WriteLine("\tWrong input, please insert a menu option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("No empty input is allowed!" + e.Message);                    
                }
            }
            //Console.ReadKey();
            Console.Clear();
        }
        //method to ask user to input a string and than save in the string variable.
        //created this method to handle errors and input validation 
        public static void AskUserString()
        {
            bool checkLength = false;
            while (checkLength == false)
            {
                Console.WriteLine("\nPlease insert a String: ");
                inputString = Console.ReadLine().Trim();
                if (inputString.Length <= 1)
                {
                    ClearDisplayMenu();
                    Console.WriteLine("\n*** You have to insert a string greater than 1 char ***");
                    checkLength = false;    
                } 
                else
                {
                    ClearDisplayMenu();
                    Console.WriteLine("\nYour string is: \n{0}", inputString);
                    checkLength = true;
                }                
            }
        }

        //method to display program menu option and avoid code repetition 
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
            Console.WriteLine("\n\r\t j. Own string operation");
            Console.WriteLine("\n\r\t n. Insert a new string");
            Console.WriteLine("\n\r\t q. Exit program");
            Console.WriteLine("\r\t ============================================");
        } 
        
        //this method is created to reduce code repetition and size 1/2
        public static void ClearDisplayMenu()
        {
            Console.Clear();
            DisplayMenu();
        }
    }
}