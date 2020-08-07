using System;

namespace MVC_CountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            while (runAgain)
            {
                CountryController cc = new CountryController() { };
                cc.WelcomeAction();

                runAgain = RunProgramAgain();
            }
        }
        public static bool RunProgramAgain()
        {
            bool validateAgain = true;
            bool repeatProgram = true;

            while (validateAgain)
            {
                Console.WriteLine("Would you like to run this program again? Enter y to run again or n to quit.");
                string playAgain = Console.ReadLine();

                if (playAgain.Length > 1 || playAgain.Length == 0)
                {
                    validateAgain = true;
                }
                else if (playAgain.ToLower() == "y")
                {
                    validateAgain = false;
                    repeatProgram = true;
                    Console.Clear();

                }
                else if (playAgain.ToLower() == "n")
                {
                    validateAgain = false;
                    repeatProgram = false;
                }
                else
                {
                    validateAgain = true;
                }
            }

            return repeatProgram;

        }
    }
}
