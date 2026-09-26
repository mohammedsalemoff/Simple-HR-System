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
* Uses a reusable `Helper` class for common application methods and input validation.

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
│   │   ├── Vacation.cs
│   │   └── Helper.cs
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

### Helper

The `Helper` class is a **static utility class** that contains reusable methods used throughout the application.

It is responsible for common tasks such as displaying formatted messages, reading user input, and validating different types of input.

#### Application Helper Methods

* `WelcomeApp()` — Displays the application welcome message.
* `PrintMessage()` — Displays a message with separators.
* `Separator()` — Prints a separator line.
* `Beauty()` — Prints decorative lines used to separate sections in the output.

#### Input Methods

* `ReadString()` — Reads and validates string input.
* `ReadNumber(int)` — Reads and validates integer input.
* `ReadNumber(decimal)` — Reads and validates decimal input.
* `ReadDate()` — Reads and validates dates using the `dd/MM/yyyy` format.
* `ReadCharacter()` — Reads and validates a character input.

#### Validation Methods

* `IsCharValid()` — Validates `Y`, `y`, `N`, or `n` input.
* `IsAgeValid()` — Validates that the age is between 18 and 59.
* `IsZero(int)` — Checks whether an integer value is zero.
* `IsZero(decimal)` — Checks whether a decimal value is zero.

The `Helper` class also demonstrates **method overloading**, such as:

* `ReadNumber()` for `int` and `decimal`.
* `IsZero()` for `int` and `decimal`.

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
* Static Classes
* Static Methods
* Method Overloading
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
git clone https://github.com/mohammedsalemoff/HR_System.git
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

The `Helper` class is used throughout the application to handle common tasks such as:

* Reading user input
* Validating input
* Displaying error messages
* Formatting console output

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
* Static helper methods
* Method overloading
* User input
* Input validation
* Organizing a C# console application
* Reusing common functionality through a helper class

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

## 📄 License

This project is open for educational and personal use.

## Author

**Mohammed Salem**

C# Developer | ASP.NET Core MVC Learner

---

⭐ If you find this project useful, feel free to give it a star!
