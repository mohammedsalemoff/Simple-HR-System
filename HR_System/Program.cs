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
                Helper.WelcomeApp("HR System");

                // A message explaining what the program can do
                Console.WriteLine(@"In this program you can:
 - select number of employees you want to enter
 - enter the basic information for these employees
 - enter the allowances the employee got and also enter information of each allowance
 - enter the deductions the employee got and also enter information of each deduction
 - enter the vacations the employee got and also enter information of each vacation");
                Helper.Separator();

                #endregion


                #region Read No. of employees

                // ask user to enter the number of employees he/she want
                int nSize = 0;
            ReadNoEmps: if (!Helper.ReadNumber("the no. of employees", out nSize))
                    goto ReadNoEmps;
            if(!Helper.IsZero(nSize))
                    goto ReadNoEmps;
                Helper.Separator();

                #endregion

                // build the Array of Employees (Each Employee represent an object form the Employee Class)
                emps = new Employee[nSize];

                #region Business Logic

                for (int i = 0; i < emps.Length; i++)
                {
                    Console.WriteLine($"Now, you will enter information of Employee no. {i + 1}");

                    #region Read Basic Information of the Employee

                    // read and validate Employee Name
                ReadEmpName: if (!Helper.ReadString("Employee Name", out empName))
                        goto ReadEmpName;
                if(empName.Length < 10)
                    {
                        Helper.PrintMessage("Error | Please enter name contains at least 10 characters");
                        goto ReadEmpName;
                    }
                    Helper.Separator();
                    // read and validate Employee Age
                ReadEmpAge: if (!Helper.ReadNumber("Employee Age", out empAge))
                        goto ReadEmpAge;
                    if (!Helper.IsAgeValid(empAge))
                        goto ReadEmpAge;
                    Helper.Separator();
                    // read Employee Birth Date
                ReadEmpBirthDate: if (!Helper.ReadDate("Employee Birth Date", out empBirthDate))
                        goto ReadEmpBirthDate;
                    Helper.Separator();
                    // read Employee Address
                ReadEmpAddress: if (!Helper.ReadString("Employee Address", out empAddress))
                        goto ReadEmpAddress;
                    Helper.Separator();
                    // read Employee Salary
                ReadEmpSalary: if (!Helper.ReadNumber("Employee Salary", out empSalary))
                        goto ReadEmpSalary;
                    if (!Helper.IsZero(empSalary))
                        goto ReadEmpSalary;
                    Helper.Separator();
                    // assign these values to the employee object using the parameterized constructor
                    emps[i] = new Employee(empName,empAddress,empBirthDate,empAge,empSalary);

                    #endregion

                    #region Read Allowances

                    while (true)
                    {
                        Console.WriteLine("To add an allowance for the employee, enter 1 to skip that step enter 0 (1 or 0 only)");
                    ReadUserChoiceAllowance: if (!Helper.ReadNumber("your choice", out nUserChoice))
                        {
                            goto ReadUserChoiceAllowance;
                        }
                        if (nUserChoice != 0 && nUserChoice != 1)
                        {
                            Helper.PrintMessage("Error | enter 1 to add and 0 to skip that step | Try Again");
                            goto ReadUserChoiceAllowance;
                        }

                        if (nUserChoice == 1)
                        {

                        ReadNameAllow: if (!Helper.ReadString("the allowance name", out allowName))
                            {
                                goto ReadNameAllow;
                            }
                            Helper.Separator();
                        ReadAmountAllow: if (!Helper.ReadNumber("the allowance amount", out allowAmount))
                            {
                                goto ReadAmountAllow;
                            }
                            if (!Helper.IsZero(allowAmount))
                                goto ReadAmountAllow;
                            Helper.Separator();
                            // passing the allowance name using the parameterized constructor
                            myAllowance = new Allowance(allowName);
                            // passing the allownace amount using the AmountProperty 
                            myAllowance.Amount = allowAmount;

                            emps[i].Allowances.Add(new Allowance() { Name= allowName,Amount=allowAmount});
                            myAllowance = new Allowance();
                        }
                        else
                        {
                            break;
                        }
                    }

                    #endregion

                    Helper.Separator();

                    #region Read Deductions

                    while (true)
                    {
                        Console.WriteLine("To add a deduction for the employee, enter 1 to skip that step enter 0 (1 or 0 only)");
                    ReadUserChoiceDeduction: if (!Helper.ReadNumber("your choice", out nUserChoice))
                        {
                            goto ReadUserChoiceDeduction;
                        }

                        if (nUserChoice != 0 && nUserChoice != 1)
                        {
                            Helper.PrintMessage("Error | enter 1 to add and 0 to skip that step | Try Again");
                            goto ReadUserChoiceDeduction;
                        }

                        if (nUserChoice == 0)
                            break;

                    ReadNameDeduction: if (!Helper.ReadString("the deduction name", out dedName))
                        {
                            goto ReadNameDeduction;
                        }
                        Helper.Separator();
                    ReadAmountDeduction: if (!Helper.ReadNumber("the deduction amount", out dedAmount))
                        {
                            goto ReadAmountDeduction;
                        }
                        if (!Helper.IsZero(dedAmount))
                            goto ReadAmountDeduction;
                        Helper.Separator();
                        myDeduction = new Deduction();
                        // passing the deduction details using the Properties
                        myDeduction.Name = dedName;
                        myDeduction.Amount = dedAmount;

                        emps[i].Deductions.Add(new Deduction() {Name = dedName,Amount = dedAmount});
                        myDeduction = new Deduction();
                    }

                    #endregion

                    Helper.Separator();

                    #region Read Vacations

                    while (true)
                    {
                        Console.WriteLine("To add a vacation for the employee, enter 1 to skip that step enter 0 (1 or 0 only)");
                    ReadUserChoiceVacation: if (!Helper.ReadNumber("your choice", out nUserChoice))
                        {
                            goto ReadUserChoiceVacation;
                        }
                        if (nUserChoice != 0 && nUserChoice != 1)
                        {
                            Helper.PrintMessage("Error | enter 1 to add and 0 to skip that step | Try Again");
                            goto ReadUserChoiceVacation;
                        }
                        if (nUserChoice == 0)
                            break;

                    ReadTypeVacation: if (!Helper.ReadString("the vacation type", out vacType))
                        {
                            goto ReadTypeVacation;
                        }
                        Helper.Separator();
                    ReadCountVacation: if (!Helper.ReadNumber("the no. of days", out vacCount))
                        {
                            goto ReadCountVacation;
                        }
                        if(!Helper.IsZero(vacCount))
                            goto ReadCountVacation;
                        Helper.Separator();
                    ReadStartVacation: if (!Helper.ReadDate("vacation start date", out vacStart))
                        {
                            goto ReadStartVacation;
                        }
                        Helper.Separator();
                    ReadEndVacation: if (!Helper.ReadDate("vacation end date", out vacEnd))
                        {
                            goto ReadEndVacation;
                        }
                        Helper.Separator();
                        myVacation = new Vacation();
                        // passing the details of the vacation using Properties
                        myVacation.Type = vacType;
                        myVacation.DaysCount = vacCount;
                        myVacation.startDate = vacStart;
                        myVacation.endDate = vacEnd;

                        emps[i].Vacations.Add(new Vacation() { Type = vacType,startDate=vacStart,endDate=vacEnd,DaysCount=vacCount});
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
                    Helper.Beauty();
                    Console.WriteLine($"Employee no. {nCounter + 1} Details:- ");
                    Console.WriteLine("----------------------------------------");
                    emps[nCounter].PrintEmployeeInfo();
                }
                Helper.Beauty();

                #endregion

                #region Ask the user to enter his/her decision to use the program again or not

                // ask the user if he/she wanna use the app again
            ReadUserDecision: Console.WriteLine(@"To use the Application again, Press y or Y only
To close the application, Press n or N only");
                if (!Helper.ReadCharacter("your decision", out cUserDecision))
                    goto ReadUserDecision;
                if (!Helper.IsCharValid(cUserDecision))
                    goto ReadUserDecision;
                if (cUserDecision == 'n' || cUserDecision == 'N')
                {
                    Helper.PrintMessage("Thank you for use | We hope you got a good experience");
                    return;
                }
                Console.Clear();
                continue;
            }

                #endregion

            #endregion

        }
    }

}
