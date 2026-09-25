# HR_System

A console-based Human Resources (HR) management system built with **C#** and **.NET 10**.

This project allows users to enter and manage basic employee information along with their **allowances, deductions, and vacations**.

The project was created as a practical application of **Object-Oriented Programming (OOP)** concepts in C#.

---

## Features

* Add multiple employees.
* Enter employee basic information:

  * Name
  * Address
  * Date of Birth
  * Age
  * Salary
* Add multiple allowances for each employee.
* Add multiple deductions for each employee.
* Add multiple vacations for each employee.
* Validate user input.
* Display all employee information in a structured format.
* Restart the application without closing it.
* Uses constructors to initialize objects.
* Uses copy constructors for creating object copies.

---

## Technologies Used

* **C#**
* **.NET 10**
* **Console Application**
* **Object-Oriented Programming (OOP)**

---

## Project Structure

```text
HR_System
│
├── HR_System
│   ├── Classes
│   │   ├── Employee.cs
│   │   ├── Allowance.cs
│   │   ├── Deduction.cs
│   │   └── Vacation.cs
│   │
│   ├── Program.cs
│   └── HR_System.csproj
│
├── HR_System.slnx
└── README.md
```

---

## Classes

### Employee

The `Employee` class represents an employee and contains:

* Name
* Address
* Date of Birth
* Age
* Salary
* List of Allowances
* List of Deductions
* List of Vacations

It also contains:

* Parameterized Constructor
* Copy Constructor
* `PrintEmployeeInfo()` method

---

### Allowance

The `Allowance` class represents an additional amount received by an employee.

Properties:

* `Name`
* `Amount`

Constructors:

* Default Constructor
* Parameterized Constructor
* Copy Constructor

---

### Deduction

The `Deduction` class represents an amount deducted from an employee.

Properties:

* `Name`
* `Amount`

Constructors:

* Default Constructor
* Copy Constructor

---

### Vacation

The `Vacation` class represents an employee vacation.

Properties:

* `startDate`
* `endDate`
* `Type`
* `DaysCount`

Constructors:

* Default Constructor
* Copy Constructor

---

## OOP Concepts Used

This project was built to practice several important C# and OOP concepts, including:

* Classes and Objects
* Properties
* Fields
* Constructors
* Parameterized Constructors
* Copy Constructors
* Encapsulation
* Object Initialization
* Collections
* `List<T>`
* Arrays
* Object Composition
* Methods
* Input Validation
* Exception-safe collection initialization

---

## How to Run

### Requirements

Make sure you have:

* [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
* Visual Studio 2022 or another C# compatible IDE

### Run the Project

Clone the repository:

```bash
git clone https://github.com/your-username/HR_System.git
```

Navigate to the project directory:

```bash
cd HR_System
```

Run the application:

```bash
dotnet run
```

---

## How It Works

When the application starts, the user is asked to enter the number of employees.

For each employee, the program collects their basic information and then gives the user the option to add:

1. Allowances
2. Deductions
3. Vacations

After entering the data, the application displays the complete information for every employee.

The user can then choose whether to run the application again or close it.

---

## Example

```text
Welcome to HR System

In this program you can:
- select number of employees you want to enter
- enter the basic information for these employees
- enter allowances
- enter deductions
- enter vacations
```

After entering the information, the employee details are displayed in the console.

---

## Learning Purpose

This project was developed as a practical exercise while learning **C# Object-Oriented Programming**.

The main goal was to practice working with:

* Multiple related classes
* Properties and fields
* Different types of constructors
* Lists of objects
* Arrays of objects
* Methods
* User input
* Input validation
* Organizing a C# console application

---

## Future Improvements

Possible improvements for future versions include:

* Add employee search functionality.
* Update employee information.
* Delete employees.
* Calculate total allowances.
* Calculate total deductions.
* Calculate net salary.
* Add stronger validation for dates and numeric values.
* Store employee data in a database.
* Build a graphical user interface.
* Add file-based data persistence.

---

## Author

**Mohammed Salem**

C# Developer | ASP.NET Core MVC Learner

---

⭐ If you find this project useful, feel free to give it a star!
