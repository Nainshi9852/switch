using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode;
            string lang;
            string choice;

            do
            {
                Console.WriteLine("Enter Country Code");
                cCode = Console.ReadLine();
                switch (cCode)
                {

                    case "uk":
                        {
                            lang = "English";
                            break;
                        }
                    case "af":
                        {
                            lang = "Dari,Pashto";
                            break;
                        }
                    case "uae":
                        {
                            lang = "Arabic";
                            break;
                        }
                    case "in":
                        {
                            lang = "Hindi,English,Tamil,telgu,Punjabi";
                            break;

                        }
                    default:
                        {
                            Console.WriteLine("$Sorry !! Your country {cCode} is not in OurDB");

                            lang = "NOT found!!!";
                            break;
                        }

                }
                Console.WriteLine("Country code \t" + cCode + " \n Language(s) \t" + lang);
                Console.WriteLine("Do you wanna continue if yes press y \n To exit press any key");
                choice = Console.ReadLine().ToLower();
            }
            while (choice=="y");

            Console.ReadKey();
        }
    }
}
