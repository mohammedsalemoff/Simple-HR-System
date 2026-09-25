using System.Drawing;
using System.Globalization;

namespace HR_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region App Variables

            string empName = "", empAddress = "", allowName = "", dedName = "", vacType = "";
            char cUserDecision = 'y';
            int empAge = 0, vacCount = 0, nUserChoice = 0;
            decimal empSalary = 0, allowAmount = 0, dedAmount = 0;
            DateTime empBirthDate = new DateTime();
            DateTime vacStart = new DateTime();
            DateTime vacEnd = new DateTime();

            #endregion

            // Declare the array of Employees without new 
            Employee[] emps;

            #region Declare the instances of Allowance, Deduction and Vacation without new

            Allowance myAllowance;
            Deduction myDeduction;
            Vacation myVacation;

            #endregion

            #region Full Program

            // This loop to keep App working after take the User Decision
            while (true)
            {

                #region Welcome the User, then explain what the Program can do

                // First, let's welcome the user 
                WelcomeApp("HR System");

                // A message explaining what the program can do
                Console.WriteLine(@"In this program you can:
 - select number of employees you want to enter
 - enter the basic information for these employees
 - enter the allowances the employee got and also enter information of each allowance
 - enter the deductions the employee got and also enter information of each deduction
 - enter the vacations the employee got and also enter information of each vacation");
                Separator();

                #endregion


                #region Read No. of employees

                // ask user to enter the number of employees he/she want
                int nSize = 0;
            ReadNoEmps: if (!ReadNumber("the no. of employees", out nSize))
                    goto ReadNoEmps;
            if(!IsZero(nSize))
                    goto ReadNoEmps;
                Separator();

                #endregion

                // build the Array of Employees (Each Employee represent an object form the Employee Class)
                emps = new Employee[nSize];

                #region Business Logic

                for (int i = 0; i < emps.Length; i++)
                {
                    Console.WriteLine($"Now, you will enter information of Employee no. {i + 1}");

                    #region Read Basic Information of the Employee

                    // read and validate Employee Name
                ReadEmpName: if (!ReadString("Employee Name", out empName))
                        goto ReadEmpName;
                if(empName.Length < 10)
                    {
                        PrintMessage("Error | Please enter name contains at least 10 characters");
                        goto ReadEmpName;
                    }
                    Separator();
                    // read and validate Employee Age
                ReadEmpAge: if (!ReadNumber("Employee Age", out empAge))
                        goto ReadEmpAge;
                    if (!IsAgeValid(empAge))
                        goto ReadEmpAge;
                    Separator();
                    // read Employee Birth Date
                ReadEmpBirthDate: if (!ReadDate("Employee Birth Date", out empBirthDate))
                        goto ReadEmpBirthDate;
                    Separator();
                    // read Employee Address
                ReadEmpAddress: if (!ReadString("Employee Address", out empAddress))
                        goto ReadEmpAddress;
                    Separator();
                    // read Employee Salary
                ReadEmpSalary: if (!ReadNumber("Employee Salary", out empSalary))
                        goto ReadEmpSalary;
                    if (!IsZero(empSalary))
                        goto ReadEmpSalary;
                    Separator();
                    // assign these values to the employee object using the parameterized constructor
                    emps[i] = new Employee(empName,empAddress,empBirthDate,empAge,empSalary);

                    #endregion

                    #region Read Allowances

                    while (true)
                    {
                        Console.WriteLine("To add an allowance for the employee, enter 1 to skip that step enter 0 (1 or 0 only)");
                    ReadUserChoiceAllowance: if (!ReadNumber("your choice", out nUserChoice))
                        {
                            goto ReadUserChoiceAllowance;
                        }
                        if (nUserChoice != 0 && nUserChoice != 1)
                        {
                            PrintMessage("Error | enter 1 to add and 0 to skip that step | Try Again");
                            goto ReadUserChoiceAllowance;
                        }

                        if (nUserChoice == 1)
                        {

                        ReadNameAllow: if (!ReadString("the allowance name", out allowName))
                            {
                                goto ReadNameAllow;
                            }
                            Separator();
                        ReadAmountAllow: if (!ReadNumber("the allowance amount", out allowAmount))
                            {
                                goto ReadAmountAllow;
                            }
                            if (!IsZero(allowAmount))
                                goto ReadAmountAllow;
                            Separator();
                            // passing the allowance name using the parameterized constructor
                            myAllowance = new Allowance(allowName);
                            // passing the allownace amount using the AmountProperty 
                            myAllowance.Amount = allowAmount;

                            emps[i].Allowances.Add(myAllowance);
                            myAllowance = new Allowance();
                        }
                        else
                        {
                            break;
                        }
                    }

                    #endregion

                    Separator();

                    #region Read Deductions

                    while (true)
                    {
                        Console.WriteLine("To add a deduction for the employee, enter 1 to skip that step enter 0 (1 or 0 only)");
                    ReadUserChoiceDeduction: if (!ReadNumber("your choice", out nUserChoice))
                        {
                            goto ReadUserChoiceDeduction;
                        }

                        if (nUserChoice != 0 && nUserChoice != 1)
                        {
                            PrintMessage("Error | enter 1 to add and 0 to skip that step | Try Again");
                            goto ReadUserChoiceDeduction;
                        }

                        if (nUserChoice == 0)
                            break;

                    ReadNameDeduction: if (!ReadString("the deduction name", out dedName))
                        {
                            goto ReadNameDeduction;
                        }
                        Separator();
                    ReadAmountDeduction: if (!ReadNumber("the deduction amount", out dedAmount))
                        {
                            goto ReadAmountDeduction;
                        }
                        if (!IsZero(dedAmount))
                            goto ReadAmountDeduction;
                        Separator();
                        myDeduction = new Deduction();
                        // passing the deduction details using the Properties
                        myDeduction.Name = dedName;
                        myDeduction.Amount = dedAmount;

                        emps[i].Deductions.Add(myDeduction);
                        myDeduction = new Deduction();
                    }

                    #endregion

                    Separator();

                    #region Read Vacations

                    while (true)
                    {
                        Console.WriteLine("To add a vacation for the employee, enter 1 to skip that step enter 0 (1 or 0 only)");
                    ReadUserChoiceVacation: if (!ReadNumber("your choice", out nUserChoice))
                        {
                            goto ReadUserChoiceVacation;
                        }
                        if (nUserChoice != 0 && nUserChoice != 1)
                        {
                            PrintMessage("Error | enter 1 to add and 0 to skip that step | Try Again");
                            goto ReadUserChoiceVacation;
                        }
                        if (nUserChoice == 0)
                            break;

                    ReadTypeVacation: if (!ReadString("the vacation type", out vacType))
                        {
                            goto ReadTypeVacation;
                        }
                        Separator();
                    ReadCountVacation: if (!ReadNumber("the no. of days", out vacCount))
                        {
                            goto ReadCountVacation;
                        }
                        if(!IsZero(vacCount))
                            goto ReadCountVacation;
                        Separator();
                    ReadStartVacation: if (!ReadDate("vacation start date", out vacStart))
                        {
                            goto ReadStartVacation;
                        }
                        Separator();
                    ReadEndVacation: if (!ReadDate("vacation end date", out vacEnd))
                        {
                            goto ReadEndVacation;
                        }
                        Separator();
                        myVacation = new Vacation();
                        // passing the details of the vacation using Properties
                        myVacation.Type = vacType;
                        myVacation.DaysCount = vacCount;
                        myVacation.startDate = vacStart;
                        myVacation.endDate = vacEnd;

                        emps[i].Vacations.Add(myVacation);
                        myVacation = new Vacation();
                    }

                    #endregion

                    Console.Clear();
                }
                #endregion

                #region Print The Output on the screen

                // this statement to clear the console screen to show the output
                Console.Clear();

                for (int nCounter = 0; nCounter < emps.Length; ++nCounter)
                {
                    Beauty();
                    Console.WriteLine($"Employee no. {nCounter + 1} Details:- ");
                    Console.WriteLine("----------------------------------------");
                    emps[nCounter].PrintEmployeeInfo();
                }
                Beauty();

                #endregion

                #region Ask the user to enter his/her decision to use the program again or not

                // ask the user if he/she wanna use the app again
            ReadUserDecision: Console.WriteLine(@"To use the Application again, Press y or Y only
To close the application, Press n or N only");
                if (!ReadCharacter("your decision", out cUserDecision))
                    goto ReadUserDecision;
                if (!IsCharValid(cUserDecision))
                    goto ReadUserDecision;
                if (cUserDecision == 'n' || cUserDecision == 'N')
                {
                    PrintMessage("Thank you for use | We hope you got a good experience");
                    return;
                }
                Console.Clear();
                continue;
            }

                #endregion

            #endregion

        }

        #region App_Methods

        // 1- Welcome Message Method
        static void WelcomeApp(string appName)
        {
            Console.ReadKey();
            Console.WriteLine("**************************************************************************************************************************");
            Console.WriteLine(@$"Hi, sir
Welcome to {appName} Application
We hope you have a nice time with us
**************************************************************************************************************************");
        }

        // 2- Print Any Message in beautiful form
        static void PrintMessage(string message)
        {
            Separator();
            Console.WriteLine(message);
            Separator();
        }

        // 3- Print a Separator between the lines
        static void Separator()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }

        // 4- Print 2 lines to separate between the employees in the output show step and also at the end of the program
        static void Beauty()
        {
            Console.WriteLine("**************************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************************");
        }

        // 5- Read a string value from the user and validate it
        static bool ReadString(string field, out string str)
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
        static bool ReadNumber(string part, out int number)
        {
            Console.Write($"Please, enter {part}: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                PrintMessage("Error | You entered a not valid number | Try again");
                return false;
            }
            if(number < 0)
            {
                PrintMessage("Error | Don't enter a negative value | Try again");
                return false;
            }
            return true;
        }

        // 7- Read a decimal number from the user then validate it (---OVRLOADING---)
        static bool ReadNumber(string part, out decimal number)
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
        static bool ReadDate(string part, out DateTime dt)
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
        static bool ReadCharacter(string part,out char cUserInput)
        {
            Console.Write($"Please, enter {part}: ");
            if(!char.TryParse(Console.ReadLine(),out cUserInput))
            {
                PrintMessage("Error | You entered a not valid character | Try Again");
                return false;
            }
            return true;
        }

        // 10- Is (y,Y,n and N) method check
        static bool IsCharValid(char cInput)
        {
            if(cInput != 'n' && cInput != 'N' && cInput != 'y' && cInput != 'Y')
            {
                PrintMessage($"Error | You enter {cInput} character | Enter (n,N,y and Y) only | Try again");
                return false;
            }
            return true;
        }

        // 11- Is valid age method, just between 18 and 59 values
        static bool IsAgeValid(int age)
        {
            if(age<18 || age > 59)
            {
                PrintMessage("Error | Enter an age from 18 to 59 only | Try Again");
                return false;
            }
            return true;
        }

        // 12- Is Zero or not (---OVERLOADING---)
        static bool IsZero(int number)
        {
            if(number == 0)
            {
                PrintMessage("Error | Enter a positive value not zero | Try Again");
                return false;
            }
            return true;
        }

        // 13- Is Zero or not (---OVERLOADING---)
        static bool IsZero(decimal number)
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
