
using myLibrary_Ass1_OOP;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment5
{
    internal class Program
    { 
       
        
        static void Main(string[] args)
        {

            #region Demo (part 01)
            #region Enum
            //Grade myG = Grade.A; //A
            //Grade myG2 = (Grade)3;//f

            //object? mygrade2 = Gender.male; //Boxing
            //Enum.TryParse(typeof(Gender), "Male", false, out  mygrade2);
            //Gender myG1=Gender.m;
            //Enum.TryParse("male", false, out  myG1);//false is false for ignore sensitive
            //Console.WriteLine(myG);
            //Console.WriteLine(myG2); 
            #endregion

            #region Struct
            //Point p1; // is object of type point not reference
            //          //CLR will Allocate (8 byte ->4 for int x, 4 for int y)
            //p1 = new Point(); // new with struct is just only for constructor selection that will intialize attributes of object (p1)

            //Console.WriteLine(p1.ToString()); //return namespace .DataType

            //int x = 10;
            //x.ToString();
            //Console.WriteLine(x.ToString());
            #endregion

            #region Encapsulation
            //Employee emp=new Employee(10,"ahmed",4000);
            /////1.1 Apply Encapsulation with setter ,getter
            ////emp.setID(20190180) ;
            ////emp.setName("ali");
            ////Console.WriteLine(emp.getName);

            /////1.2  Apply Encapsulation with Property
            //emp.Salary = 8000;
            //Console.WriteLine(emp.Salary); 

            #endregion


            #endregion

            #region Assignment1_OOP
            #region 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //for (int i = 0; i < Enum.GetValues(typeof(WeekDays)).Length; i++)
            //{
            //    Console.WriteLine((WeekDays)i);

            //} 
            #endregion


            #region 2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //person[] people = new person[3];
            //people[0].Age = 22;
            //people[0].Name = "ahmed";
            //people[1].Age = 30;
            //people[1].Name = "amr";
            //people[2].Age = 18;
            //people[2].Name = "mona";

            ////or another way
            //people[0] = new person(22, "ahmed");
            //people[1] = new person(30, "amr");
            //people[2] = new person(18, "mona");

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine(people[i]);
            //} 
            #endregion


            #region 3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //string? inputData;
            //Season selectedSeason;

            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //inputData = Console.ReadLine();
            //Enum.TryParse(inputData, true, out selectedSeason);
            //// Enum.TryParse(season, out Season selectedSeason);

            //if (selectedSeason == Season.Spring) { Console.WriteLine("Month Range: March to May"); }
            //else if (selectedSeason == Season.Summer) { Console.WriteLine("Month Range: june to august"); }
            //else if (selectedSeason == Season.Autumn) { Console.WriteLine("Month Range: September to November"); }
            //else if (selectedSeason == Season.Winter) { Console.WriteLine("Month Range: December to February"); }

            //else
            //{
            //    Console.WriteLine("InputData is invaild season .");
            //} 
            #endregion


            #region 4.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Permissions userpermession = Permissions.write | Permissions.Read | Permissions.Execute | Permissions.Delete;
            //// Display the initial permissions
            //Console.WriteLine("Initial Permissions: " + userpermession);

            ////// Add a permission 
            //userpermession |= Permissions.Execute;
            //Console.WriteLine("After Adding Execute Permission: " + userpermession);

            ////// Remove a permission 
            //userpermession &= ~Permissions.write;
            //Console.WriteLine("After Removing Write Permission: " + userpermession);

            //bool haspermission = (userpermession & Permissions.Execute) != 0;
            //Console.WriteLine("Has Execute Permission: " + haspermission); 
            #endregion


            #region 5.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("Please enter Color to check if is prime color");
            //string? userinput = Console.ReadLine();
            //Colors PrimeColor;
            //if (Enum.TryParse(userinput, true, out PrimeColor))
            //{
            //    string message;
            //    if (PrimeColor == Colors.Green || PrimeColor == Colors.Blue || PrimeColor == Colors.Red)
            //    {
            //        Console.WriteLine($"Input color is Prime Color {userinput}");
            //    }
            //    else Console.WriteLine($"Input color isn''t Prime Color {userinput}");
            //}

            //else Console.WriteLine("Invalid color input .");

            #endregion


            #region 6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("please enter first point (x ,y)");
            //double X1, Y1, X2, Y2;
            //X1 = Convert.ToDouble(Console.ReadLine());
            //Y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("please enter second point (x ,y)");
            //X2 = Convert.ToDouble(Console.ReadLine());
            //Y2 = Convert.ToDouble(Console.ReadLine());

            //Points p1 = new Points(X1, Y1);
            //Points p2 = new Points(X2, Y2);

            //double deltaX = p2.X - p1.X;
            //double deltaY = p2.Y - p1.Y;
            //double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            //Console.WriteLine($"Distance between two points = {distance}");  
            #endregion

            #region 7.	Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //person[] people = new person[3];
            //string? name;
            //int age;
            //Console.WriteLine("please enter first person  his name and his age: ");
            //name = Console.ReadLine();
            //age = Convert.ToInt32(Console.ReadLine());
            //people[0] = new person(name, age);
            //Console.WriteLine("please enter second person  his name and his age: ");
            //name = Console.ReadLine();
            //age = Convert.ToInt32(Console.ReadLine());
            //people[1] = new person(name, age);
            //Console.WriteLine("please enter third person  his name and his age: ");
            //name = Console.ReadLine();
            //age = Convert.ToInt32(Console.ReadLine());
            //people[2] = new person(name, age);

            //person oldest = new person();

            //for (int i = 0; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age) { oldest = people[i]; }

            //}
            //Console.WriteLine(oldest); 
            #endregion

            ////////////////part 03
            #region part3 _ 1.	Design and implement a Class for the employees in a company:
            //Employee emp =new Employee(20190180,"hassnaa","HighLevel",5000, DateTime.Parse("2023/07/20"),"female");

            //emp.DisplayDataOfEmployee(); 
            #endregion

            #region 2.	Develop a Class to represent the Hiring Date Data:⮚	consisting of fields to hold the day, month and Years.


            // HiringDate hiredate = new HiringDate(20,7,2023);
            //Employee emp=new Employee(20190180, "hassnaa", "HighLevel", 5000, hiredate, "female");
            // emp.DisplayDataOfEmployee();

            #endregion

            #region   3.	We need to restrict the Gender field to be only M or F [Male or Female] 
            //HiringDate hiredate = new HiringDate(20, 7, 2023);

            //Gender gender =Gender.female;

            //Employee emp = new Employee(20190180, "hassnaa", "HighLevel", 5000, hiredate, gender);
            //emp.DisplayDataOfEmployee();

            #endregion


            #region    4.	Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
            //HiringDate hiredate = new HiringDate(20, 7, 2023);

            //Gender gender = Gender.female;
            //SecurityPrivilege privilege = SecurityPrivilege.Developer;
            //Employee emp = new Employee(20190180, "hassnaa", privilege, 5000, hiredate, gender);
            //emp.DisplayDataOfEmployee();
            #endregion


            #region  5.	We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]
            //HiringDate hiredate = new HiringDate(20, 7, 2023);

            //Gender gender = Gender.female;
            //SecurityPrivilege privilege = SecurityPrivilege.Developer;
            //Employee emp = new Employee(20190180, "hassnaa", privilege, 5000, hiredate, gender);
            //Console.WriteLine(emp); 
            #endregion

            #region   6.	Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //HiringDate hiredate1 = new HiringDate(20, 7, 2023);


            //Employee dba = new Employee(20190180, "hassnaa", SecurityPrivilege.DBA, 5000, hiredate1,Gender.f);
            //HiringDate hiredate2 = new HiringDate(15, 2, 2023);
            //Employee Guest = new Employee(20190454, "mahinaz", SecurityPrivilege.Guest, 9000, hiredate2, Gender.female);
            //HiringDate hiredate3 = new HiringDate(5, 8, 2022);
            //Employee securityOfficer = new Employee(20102411, "mohamed", SecurityPrivilege.Secretary, 7000, hiredate3, Gender.m);


            //Employee[] EmpArr = { dba, Guest, securityOfficer };

            //foreach (Employee emp in EmpArr) { Console.WriteLine(emp);
            //    Console.WriteLine();
            //}
            #endregion

            #endregion



        }

    }

    }

