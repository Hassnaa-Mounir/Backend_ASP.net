using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace myLibrary_Ass1_OOP
{
    #region Demo (part_1 of Assignment_oop 1 )

    #region Enum
    //public enum Grade { A, B, C, F } //labels 
    //                                 //CLR will deals with labels as integer index you can give values for labels

    // public enum Gender { male = 1, m = 1, female = 2, f = 2 }

    //enum departments : int { CS,Is,DS,IT,AI}
    //enum Branches : byte { dokki,maydi,nasr_city } //1byte=8bits --> 0-255

    #endregion

    #region struct
    //internal struct point 
    //{
    //    public int x; public int y;
    //    public point()
    //    {
    //        x = 0; y=0;
    //    }
    //    public point(int x ,int y)
    //    {
    //        this.x=x; this.y=y;
    //    }
    //    public override string ToString() { return $"({x},{y})"; }
    //}

    #endregion

    #region Encapsulation
    //public struct Employee 
    //{ 
    //    //make data (attributes) private
    //    private int id;
    //    private string name;
    //    private decimal salary;

    //    ///1.1 Apply Encapsulation with setter ,getter
    //    //make setter ,getter
    //    //public int getID() { return id; }
    //    //public void setID(int id) { this.id = id; }
    //    //public string getName() { return name; }
    //    //public void setName(string name) { this.name = name; }

    //    ///1.2  Apply Encapsulation with Property
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public decimal Salary {
    //        get { return salary; }
    //        set { salary = value < 6000 ? 6000 : value; } } //control Data Validation
    //    private decimal deduction;

    //    public decimal Deduction
    //    {
    //        get { return Salary*0.1M; }
           
    //    }
    //    //read only also is arrival attribute

    //    public Employee(int id, string name, decimal salary) 
    //    {
    //     this.id = id;
    //        this.name = name;
    //        this.salary = salary;
    //    }
    //    public override string ToString() { return $"id : {id}/n name: {name} /n salary: {salary:C}"; }
    
    //}
    #endregion


    #endregion

    #region 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
    //public enum WeekDays
    //{ Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    #endregion

    #region 2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
    //public struct person
    //{

    //    public int Age { get; set; }
    //    public string Name { get; set; }

    //    public person(int _age, string _name)
    //    {
    //        Age = _age;
    //        Name = _name;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Name : {Name}  , yourAge : {Age}";
    //    }
    //} 
    #endregion



    #region 3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
    //public enum Season
    //{
    //    Spring, Summer, Autumn, Winter
    //}

    #endregion


    #region 4.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
    //public enum Permissions
    //{ Read, write, Delete , Execute }

    #endregion



    #region 5.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
    //public enum Colors { Red, Green, Blue } 
    #endregion

    #region 6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
    //public struct Points
    //{


    //    private double x;

    //    public double X
    //    {
    //        get; set;
    //    }
    //    private double y;

    //    public double Y
    //    {
    //        get; set;
    //    }

    //    //constructor
    //    public Points() { x = default; y = default; }
    //    public Points(double x, double y)
    //    {
    //        // this.x = x;
    //        // this.y = y;
    //        X = x;
    //        Y = y;
    //    }

    //} 
    #endregion

    #region 7.	Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
    //public struct person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public person(string name, int age) { Name = name; Age = age; }
    //    public override string ToString()
    //    {
    //        return $" Name of person : {Name} ,Age of person : {Age} ";
    //    }
    //}

    #endregion

    ///////////////////part 03
    #region Part3_ 1.	Design and implement a Class for the employees in a company:
    //public class Employee
    //{

    //    public int ID;
    //    public string Name;
    //    public string securitylevel;
    //    public double salary;
    //    public DateTime hireDate;
    //    public string Gender;


    //    public Employee(int id, string name, string secuirtyLevel, double salary, DateTime hireDate, string gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        securitylevel = secuirtyLevel;
    //        this.salary = salary;
    //        this.hireDate = hireDate;
    //        Gender = gender;
    //    }
    //    public void DisplayDataOfEmployee()
    //    {
    //        Console.WriteLine($"ID of employee is {ID}");
    //        Console.WriteLine($"Name of employee is {Name}");
    //        Console.WriteLine($"SecuiretyLevel of employee is {securitylevel}");
    //        Console.WriteLine($"salary of employee is {salary}");
    //        Console.WriteLine($"HireDate of employee is {hireDate}");
    //        Console.WriteLine($"Gender of employee is {Gender}");
    //    }
    //}
    #endregion

    #region   2.	Develop a Class to represent the Hiring Date Data:
    //public class HiringDate {
    //    private int day;

    //    public int Day
    //    {
    //        get; set;
    //    }
    //    private int month;

    //    public int Month
    //    {
    //        get; set;
    //    }
    //    private int year;

    //    public int Year
    //    {
    //        get; set;
    //    }

    //    //constructor 
    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }
    //  //  public void DisplayHireDate() { Console.WriteLine($"HireDate is {year}/{month}/{day}"); }

    //    public override string ToString()
    //    {        return $"{Year}/{Month}/{Day}";
    //        }
    //}
    //public class Employee
    //{

    //    public int ID;
    //    public string Name;
    //    public string securitylevel;
    //    public double salary;
    //    public string Gender;
    //    public HiringDate HD;

    //    public Employee(int id, string name, string secuirtyLevel, double salary, HiringDate hireDate, string gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        securitylevel = secuirtyLevel;
    //        this.salary = salary;
    //        HD = hireDate;
    //        Gender = gender;
    //    }
    //    public void DisplayDataOfEmployee()
    //    {
    //        Console.WriteLine($"ID of employee is {ID}");
    //        Console.WriteLine($"Name of employee is {Name}");
    //        Console.WriteLine($"SecuiretyLevel of employee is {securitylevel}");
    //        Console.WriteLine($"salary of employee is {salary}");
    //        Console.WriteLine($"HireDate of employee is {HD}");
    //        Console.WriteLine($"Gender of employee is {Gender}");
    //    }
    //} 
    #endregion

    #region   3.	We need to restrict the Gender field to be only M or F [Male or Female] 
    // public enum Gender { male =1 ,m=1, female=2,f=2 }  

    //public class HiringDate
    //{
    //    private int day;

    //    public int Day
    //    {
    //        get; set;
    //    }
    //    private int month;

    //    public int Month
    //    {
    //        get; set;
    //    }
    //    private int year;

    //    public int Year
    //    {
    //        get; set;
    //    }

    //    //constructor 
    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }
    //    //  public void DisplayHireDate() { Console.WriteLine($"HireDate is {year}/{month}/{day}"); }

    //    public override string ToString()
    //    {
    //        return $"{Year}/{Month}/{Day}";
    //    }
    //}
    //public class Employee
    //{

    //    public int ID;
    //    public string Name;
    //    public string securitylevel;
    //    public double salary;
    //    public Gender gender;
    //    public HiringDate HD;
    //    public Gender Gender { get; set; }
    //    public Employee(int id, string name, string secuirtyLevel, double salary, HiringDate hireDate, Gender gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        securitylevel = secuirtyLevel;
    //        this.salary = salary;
    //        HD = hireDate;
    //        Gender = gender;    
    //    }
    //    public void DisplayDataOfEmployee()
    //    {
    //        Console.WriteLine($"ID of employee is {ID}");
    //        Console.WriteLine($"Name of employee is {Name}");
    //        Console.WriteLine($"SecuiretyLevel of employee is {securitylevel}");
    //        Console.WriteLine($"salary of employee is {salary}");
    //        Console.WriteLine($"HireDate of employee is {HD}");
    //        Console.WriteLine($"Gender of employee is {Gender}");
    //    }
    //} 
    #endregion

    #region   4.	Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
    //public enum Gender { male = 1, m = 1, female = 2, f = 2 }
    //public enum SecurityPrivilege {
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA
    //}
    //public class HiringDate
    //{
    //    private int day;

    //    public int Day
    //    {
    //        get; set;
    //    }
    //    private int month;

    //    public int Month
    //    {
    //        get; set;
    //    }
    //    private int year;

    //    public int Year
    //    {
    //        get; set;
    //    }

    //    //constructor 
    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }
    //    //  public void DisplayHireDate() { Console.WriteLine($"HireDate is {year}/{month}/{day}"); }

    //    public override string ToString()
    //    {
    //        return $"{Year}/{Month}/{Day}";
    //    }
    //}
    //public class Employee
    //{

    //    public int ID;
    //    public string Name;
    //    public SecurityPrivilege securitylevel;
    //    public double salary;
    //    public Gender gender;
    //    public HiringDate HD;
    //    public Gender Gender { get; set; }
    //    public SecurityPrivilege Securitylevel { get; set; }
    //    public Employee(int id, string name, SecurityPrivilege secuirtyLevel, double salary, HiringDate hireDate, Gender gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        Securitylevel = secuirtyLevel;
    //        this.salary = salary;
    //        HD = hireDate;
    //        Gender = gender;
    //    }
    //    public void DisplayDataOfEmployee()
    //    {
    //        Console.WriteLine($"ID of employee is {ID}");
    //        Console.WriteLine($"Name of employee is {Name}");
    //        Console.WriteLine($"SecuiretyLevel of employee is {Securitylevel}");
    //        Console.WriteLine($"salary of employee is {salary}");
    //        Console.WriteLine($"HireDate of employee is {HD}");
    //        Console.WriteLine($"Gender of employee is {Gender}");
    //    }
    //} 
    #endregion

    #region   5.	We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]
    //public enum Gender { male = 1, m = 1, female = 2, f = 2 }
    //public enum SecurityPrivilege
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA
    //}
    //public class HiringDate
    //{
    //    private int day;

    //    public int Day
    //    {
    //        get; set;
    //    }
    //    private int month;

    //    public int Month
    //    {
    //        get; set;
    //    }
    //    private int year;

    //    public int Year
    //    {
    //        get; set;
    //    }

    //    //constructor 
    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }
    //    //  public void DisplayHireDate() { Console.WriteLine($"HireDate is {year}/{month}/{day}"); }

    //    public override string ToString()
    //    {
    //        return $"{Year}/{Month}/{Day}";
    //    }
    //}
    //public class Employee
    //{

    //    public int ID;
    //    public string Name;
    //    public SecurityPrivilege securitylevel;
    //    public double salary;
    //    public Gender gender;
    //    public HiringDate HD;

    //    public Gender Gender { get; set; }
    //    public SecurityPrivilege Securitylevel { get; set; }
    //    public Employee()
    //    {
    //        ID = 0;
    //        Name = " ";
    //        this.salary = salary;
    //    }
    //    public Employee(int id, string name, SecurityPrivilege secuirtyLevel, double salary, HiringDate hireDate, Gender gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        Securitylevel = secuirtyLevel;
    //        this.salary = salary;
    //        HD = hireDate;
    //        Gender = gender;
    //    }


    //    public override string ToString()
    //    {
    //        return string.Format("Employee ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nGender: {4}\nHire Date: {5}",
    //        ID, Name, Securitylevel, salary, Gender, HD);
    //    }


    //}
    #endregion



}


