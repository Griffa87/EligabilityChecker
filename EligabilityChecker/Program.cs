using System;
using System.Threading;

namespace EligabiltyChecker
{
    public class Program
    {
        public static void Main()
        {
            //Requirements for Congress
            int senatorAge = 30;
            int senatorLegnth = 9;

            int repAge = 27;
            int repLegnth = 7;

            //Program main body
            Console.WriteLine("\t\t    Welcome to the US Congress eligibility checker.");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.Write("Please enter your age: ");
            int appAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many years have you been a resident of The United States: ");
            int yearsResident = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You are {appAge} years old. And you have been a resident of The United States for {yearsResident} years.");
            Console.ResetColor();
            Console.WriteLine("Please wait while your data is analysed...");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Thread.Sleep(5000);
            Console.WriteLine("Analyses complete!");
            Thread.Sleep(1750);

            //Compound boolean expressions to handle analyses
            {
                if (appAge >= senatorAge && yearsResident >= senatorLegnth)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Congratulations! You are eligible to apply as the US Senetor, or the US Representative.");
                    Console.ResetColor();
                }
                else if (appAge >= repAge && yearsResident >= repLegnth)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Congratulations! You are able to apply as the US Representative.");
                    Console.ResetColor();
                }
                else if (appAge < repAge || yearsResident < repLegnth)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, you are unable to apply to Congress at this time.");
                    Console.ResetColor();
                }
                
                //Program exit 
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Thread.Sleep(1750);
                Console.WriteLine("Thank you for using the Congress eligabilty checker.");
                Console.WriteLine();
            }
        }
    }
}
