using System;
using System.Collections.Generic;
using System.Text;

namespace HR_System
{
    public class Employee
    {

        #region Fields
        private int _Age;
        private decimal _Salary;
        private DateTime _DateOfBirth;
        #endregion

        #region Properties

        // Read-Write Property for the Employee Name
        public string Name { get; set; }

        // Read-Write Property for the Employee Address
        public string Address { get; set; }

        // Read-Only Property for the Employee Birth Date
        public DateTime DateOfBirth
        {
            set
            {
                _DateOfBirth = value;
            }
        }

        // Read-Only Property for the Employee Age 
        public int Age
        {
            set
            {
                _Age = value;
            }
        }

        public decimal Salary
        {
            set
            {
                _Salary = value;
            }
        } 

        public List<Allowance> Allowances { get; set; }

        public List<Deduction> Deductions { get; set; }

        public List<Vacation> Vacations { get; set; }


        #endregion

        #region Methods

        #region Constructors

        // Default Constructor
        public Employee()
        {
            this.Allowances = new List<Allowance>();
            this.Deductions = new List<Deduction>();
            this.Vacations = new List<Vacation>();
        }

        // Parameterzied Constructor
        public Employee(string name,string address,DateTime birthDate,int age,decimal salary)
        {
            this.Name = name;
            this.Address = address;
            this.DateOfBirth = birthDate;
            this.Age = age;
            this.Salary = salary;
            // to avoid the NullReference Exception during working with them
            this.Allowances = new List<Allowance>();
            this.Deductions = new List<Deduction>();
            this.Vacations = new List<Vacation>();
        }
        
        // Copy Constructor 
        public Employee(Employee emp)
        {
            this.Salary = emp._Salary;
            this.Name = emp.Name;
            this.Address = emp.Address;
            this.DateOfBirth = emp._DateOfBirth;
            this.Age = emp._Age;
            this.Allowances = new List<Allowance>(emp.Allowances);
            this.Deductions = new List<Deduction>(emp.Deductions);
            this.Vacations = new List<Vacation>(emp.Vacations);

        }

        #endregion

        #region The Class Methods

        // This method to print the full data of the Employee
        public void PrintEmployeeInfo()
        {
            Console.WriteLine(@$"Basics info:-
  - Employee name: {this.Name}
  - Age: {this._Age}
  - Date of birth: {this._DateOfBirth.ToString("dd/MM/yyyy")}
  - Address: {this.Address}
  - Salary: {this._Salary}");
            this.Separator();
            int count = 0;
            Console.WriteLine("Allownaces:-");
            foreach (Allowance i in this.Allowances)
            {
                Console.WriteLine($@"  Allowance {count + 1}
Allowance Name: {i.Name} ----- Allowance Amount: {i.Amount}

");
                count++;
            }
            this.Separator();
            count = 0;
            Console.WriteLine(@"Deductions:-");
            foreach (Deduction i in this.Deductions)
            {
                Console.WriteLine($@"  Deduction{count + 1}  
Deduction Name: {i.Name} ----- Deduction Amount: {i.Amount}

");
                count++;
            }
            Separator();
            count = 0;
            Console.WriteLine("Vacations:-");
            foreach (Vacation i in this.Vacations)
            {

                Console.WriteLine($@"  Vacation {count + 1}
Start Date: {i.startDate.ToString("dd/MM/yyyy")} ----- End Date: {i.endDate.ToString("dd/MM/yyyy")}
Type: {i.Type} ----- Days Count: {i.DaysCount}

");
                count++;
            }
        }

        // This method used to separate between the lines
        private void Separator()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        } 

        #endregion

        #endregion

    }
}
