using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOconsoleApp
{
    internal class DisplayBanner
    {
        //this class is created to display a intro at the start of the application
        public static void DisplayBannerA()
        {            
            string inputD1 = "      <<<<<<<<<<  >>>>>>>>>>";
            string inputD2 = "         <<< Welcome >>>";
            string inputD3 = "<<< String manipulation program >>>";
            string inputD4 = "      <<<<<<<<<<  >>>>>>>>>>";
            string sInput = inputD1;
            char[] charArray1 = sInput.ToCharArray();

            Console.WriteLine("Press enter to start.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n");
            Console.Write("\n\r\t");
            
            //used 'for' loop to display banner grafic of each char individual
            for (int i = 0; i < charArray1.Length; i++)
            {
                Console.Write(charArray1[i]);
                Thread.Sleep(25);
            }

            Console.WriteLine("\n");
            Console.Write("\n\r\t");
            sInput = inputD2;
            char[] charArray2 = sInput.ToCharArray();

            for (int i = 0; i < charArray2.Length; i++)
            {
                Console.Write(charArray2[i]);
                Thread.Sleep(25);
            }

            Console.WriteLine("\n");
            Console.Write("\n\r\t");
            sInput = inputD3;
            char[] charArray3 = sInput.ToCharArray();

            for (int i = 0; i < charArray3.Length; i++)
            {
                Console.Write(charArray3[i]);
                Thread.Sleep(25);
            }

            Console.WriteLine("\n");
            Console.Write("\n\r\t");
            sInput = inputD4;
            char[] charArray4 = sInput.ToCharArray();

            for (int i = 0; i < charArray4.Length; i++)
            {
                Console.Write(charArray4[i]);
                Thread.Sleep(25);
            }
            Thread.Sleep(100);
            Console.Write("\n");
            Console.WriteLine("\n<<< Welcome to the String manipulation program >>>");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
