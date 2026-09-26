using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HR_System
{
    public static class Helper
    {

        #region App_Helper_Methods

        // 1- Welcome Message Method
        public static void WelcomeApp(string appName)
        {
            Console.ReadKey();
            Console.WriteLine("**************************************************************************************************************************");
            Console.WriteLine(@$"Hi, sir
Welcome to {appName} Application
We hope you have a nice time with us
**************************************************************************************************************************");
        }

        // 2- Print Any Message in beautiful form
        public static void PrintMessage(string message)
        {
            Separator();
            Console.WriteLine(message);
            Separator();
        }

        // 3- Print a Separator between the lines
        public static void Separator()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }

        // 4- Print 2 lines to separate between the employees in the output show step and also at the end of the program
        public static void Beauty()
        {
            Console.WriteLine("**************************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************************");
        }

        // 5- Read a string value from the user and validate it
        public static bool ReadString(string field, out string str)
        {
            Console.Write($"Please,enter {field}: ");
            str = Console.ReadLine();
            if (str == string.Empty)
            {
                PrintMessage("Error | You entered a not valid string | Try again");
                return false;
            }
            return true;
        }

        // 6- Read an integer number from the user and validate it (---OVRLOADING---)
        public static bool ReadNumber(string part, out int number)
        {
            Console.Write($"Please, enter {part}: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                PrintMessage("Error | You entered a not valid number | Try again");
                return false;
            }
            if (number < 0)
            {
                PrintMessage("Error | Don't enter a negative value | Try again");
                return false;
            }
            return true;
        }

        // 7- Read a decimal number from the user then validate it (---OVRLOADING---)
        public static bool ReadNumber(string part, out decimal number)
        {
            Console.Write($"Please, enter {part}: ");
            if (!decimal.TryParse(Console.ReadLine(), out number))
            {
                PrintMessage("Error | You entered a not valid number | Try again");
                return false;
            }
            if (number < 0)
            {
                PrintMessage("Error | Don't enter a negative value | Try again");
                return false;
            }
            return true;
        }

        // 8- Read a DateTime from the user then validate it 
        public static bool ReadDate(string part, out DateTime dt)
        {
            Console.Write($"Please, enter {part} in this format Day/Month/Year like dd/MM/yyyy: ");
            bool isConverted = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);
            if (!isConverted)
            {
                PrintMessage("Error | Please, enter a valid date in this format Day/Month/Year like dd/MM/yyyy | Try Again");
                return false;
            }
            return true;
        }

        // 9- Read a character from the user then validate it
        public static bool ReadCharacter(string part, out char cUserInput)
        {
            Console.Write($"Please, enter {part}: ");
            if (!char.TryParse(Console.ReadLine(), out cUserInput))
            {
                PrintMessage("Error | You entered a not valid character | Try Again");
                return false;
            }
            return true;
        }

        // 10- Is (y,Y,n and N) method check
        public static bool IsCharValid(char cInput)
        {
            if (cInput != 'n' && cInput != 'N' && cInput != 'y' && cInput != 'Y')
            {
                PrintMessage($"Error | You enter {cInput} character | Enter (n,N,y and Y) only | Try again");
                return false;
            }
            return true;
        }

        // 11- Is valid age method, just between 18 and 59 values
        public static bool IsAgeValid(int age)
        {
            if (age < 18 || age > 59)
            {
                PrintMessage("Error | Enter an age from 18 to 59 only | Try Again");
                return false;
            }
            return true;
        }

        // 12- Is Zero or not (---OVERLOADING---)
        public static bool IsZero(int number)
        {
            if (number == 0)
            {
                PrintMessage("Error | Enter a positive value not zero | Try Again");
                return false;
            }
            return true;
        }

        // 13- Is Zero or not (---OVERLOADING---)
        public static bool IsZero(decimal number)
        {
            if (number == 0)
            {
                PrintMessage("Error | Enter a positive value not zero | Try Again");
                return false;
            }
            return true;
        }

        #endregion

    }
}
