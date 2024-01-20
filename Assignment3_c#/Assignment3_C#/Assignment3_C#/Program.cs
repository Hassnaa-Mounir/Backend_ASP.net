using System.Reflection.Metadata;

namespace Assignment3_C_
{

    // class Person { public string Name; public int Age; }

 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region control Statements 1.conditional statements [if , switch]
            //Console.WriteLine("Please Enter a Month Number Existed in 1st Quarter: ");
            //int MonthNumber = int.Parse(Console.ReadLine() ?? string.Empty);
            //string  Name = Console.ReadLine() ?? string.Empty;
            #region conditional statements if 
            #region Example1
            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Hello January");
            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Hello February");
            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Hello March");
            //}
            //else
            //{
            //    Console.WriteLine("The Entered Month Number is not Existed in 1st Quarter");
            //}
            #endregion

            #endregion
            #region conditional statements Switch
            #region Example1 for switch
            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Hello January");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hello February");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hello March");
            //        break;
            //    default:
            //        Console.WriteLine("The Entered Month Number is not Existed in 1st Quarter");
            //        break;
            //}
            #endregion
            #region Example2 for switch with string
            //with string not creat jumb Table because  cases less than or equal five it can't creat jumb table
            //switch (Name)
            //{
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;
            //    case "Mona":
            //        Console.WriteLine("Hello Mona");
            //        break;
            //    case "Mai":
            //        Console.WriteLine("Hello Mai");
            //        break;
            //    case "Maged":
            //        Console.WriteLine("Hello Maged");
            //        break;
            //    case "Aya":
            //        Console.WriteLine("Hello Aya");
            //        break;

            //}
            #endregion
            #endregion
            #region Switch can used comparison operator
            //Console.WriteLine("please Enter Your Age : ");
            //int Age = int.Parse(Console.ReadLine() ?? string.Empty);
            //switch (Age) 
            //{
            //    case > 22:
            //        Console.WriteLine("Your Age is Greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Your Age is Less than 22");
            //        break;
            //   default :
            //        Console.WriteLine("Your Age is 22");
            //        break;

            //}
            #endregion
            #region Evolution oof switch in c# 7.0
            //object input= new object();
            //input = "Ahmed";
            ////input = 5;
            ////input = 3.4;
            //switch (input) 
            //{
            //    case int Number:
            //        Console.WriteLine($"integer input : {Number}");
            //        break;
            //    case double Number:
            //        Console.WriteLine($"Double input : {Number}");
            //        break;
            //    case String Name:
            //        Console.WriteLine($"String input{Name}");
            //        break;
            //}
            #endregion

            #region switch with using Keyword when with logical operator 
            //Console.WriteLine("please Enter Your Age : ");
            //int Age = int.Parse(Console.ReadLine() ?? string.Empty);
            //switch (Age)
            //{
            //    case int when Age > 22 && Age < 30:
            //        Console.WriteLine("Your Age is Greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Your Age is Less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("Your Age is 22");
            //        break;

            //}

            #endregion
            #region SWitch with c# 8.0
            //string option = "1";
            //string message = "";
            //message = option switch
            //{
            //    "1" => "Using option 01",
            //    "2" => "Using option 02",
            //    "3" => "Using option 03",
            //    _ => "Unsupported option"
            //} ;
            // another example
            //Person person = new Person();
            //person.Name = "Ahmed";
            //person.Age = 22;

            //string message = "";
            //message = person switch
            //{
            //    {Name : "Ahmed",Age :22  } =>"Hello Ahmed",
            //    { Age:30} =>"Hello  person with 30 years old"
            //    _=> "Sorry But we Don't know you "
            //};



            #endregion

            #region Switch with c# 9.0
            //Person person = new Person();
            //person.Name = "Ahmed";
            //person.Age = 22;

            //string message = "";
            //message = person switch
            //{
            //    { Name: "Ahmed", Age: > 22 and  <28 } => "Hello Ahmed",
            //    { Age: 30 } => "Hello  person with 30 years old" ,
            //    _ => "Sorry But we Don't know you "
            //};

            //double price = 40;
            //string result = price switch
            //{ 
            //  < 10 =>"low",
            //  >= 10 and <50 =>"medium",
            //  _=> "high"
            //};
            #endregion

            #endregion

            #region control statements 2- loop statements [for ,foreach]
            ////                0 1  2  3  4
            //int[] Numbers = { 1,2 ,3 ,4 ,5};
            //for (int i = 0; i < Numbers.Length; i++) { Console.WriteLine(Numbers[i]); }

            //Console.WriteLine("***********************************");
            //foreach (int number in Numbers) { Console.WriteLine(number); }

            #endregion

            #region control statements 2- loop statements [while ,do while]
            //int number;
            //do 
            //{// this code executed at least once
            //    Console.WriteLine("please Enter an Even Number : ");
            //    number=int.Parse(Console.ReadLine());
            //} 
            //while (number % 2 == 1 );

            ///  another example
            //int number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("please Enter ");
            //    flag=int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag);


            #endregion


            #endregion



            #region Assignment3_C#
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("please Enter Number for checked : ");
            //int number =int .Parse(Console.ReadLine()?? string.Empty);
            //if (number % 3 == 0 && number % 4 == 0)
            //    Console.WriteLine("Yes ,Number can Divided on 3 and 4");
            //else 
            //{
            //    Console.WriteLine("No ,Number can't Divided on 3 and 4");
            //}
            #endregion

            #region  2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("please Enter Number  : ");
            //int CheckNumber =int .Parse(Console.ReadLine()?? string.Empty);
            //if (CheckNumber < 0)
            //    Console.WriteLine("It is Negative Number");
            //else 
            //{
            //    Console.WriteLine("It is Positive Number");
            //}

            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("Please Enter Three Numbers : ");
            //int num1 =int .Parse(Console.ReadLine()?? string.Empty);
            //int num2 = int.Parse(Console.ReadLine() ?? string.Empty);
            //int num3 = int.Parse(Console.ReadLine() ?? string.Empty);
            //int min = 1000000, max = 0;
            //int[] array = {num1 , num2 , num3 };    
            // for (int i = 0; i < array.Length; i++) 
            //{
            //    if (array[i] > max )
            //        max = array[i];
            //    if (array[i] < min) 
            //        min = array[i]; 
            //}
            //Console.WriteLine($"Max Number is {max}");
            //Console.WriteLine($"Min Number is {min}");
            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("please Enter Number  : ");
            //int CheckNumber = int.Parse(Console.ReadLine() ?? string.Empty);
            //if (CheckNumber %2 ==0)
            //    Console.WriteLine("It is Even Number");
            //else
            //{
            //    Console.WriteLine("It is Odd Number");
            //}


            #endregion


            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("Please Enter your character : ");
            //char character = char.Parse(Console.ReadLine() ?? string.Empty);
            //char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
            //character =char.ToLower(character);
            //if (vowel.Contains(character))
            //    Console.WriteLine("It is Vowel Character");
            //else
            //    Console.WriteLine("It is consonant Character");

            //// another way to soluation

            //Console.WriteLine("Please Enter your character : ");
            //char character = char.Parse(Console.ReadLine() ?? string.Empty);
            //character = char.ToLower(character);
            //switch (character)
            //{
            //    case char when character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u':
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;

            //}

            #endregion

            #region 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine(" Please Enter Number : ");
            //int Number =int.Parse(Console.ReadLine() ?? string.Empty);
            // for (int i = 1; i <= Number; i++) 
            //{
            //    Console.WriteLine(i);

            //}
            #endregion

            #region  7-Write a program that allows the user to insert an integer then   print a multiplication table up to 12.
            //Console.WriteLine(" Please Enter Number : ");
            //int Number =int.Parse(Console.ReadLine() ?? string.Empty);
            //for (int i = 1; i <= 12; i++) 
            //{
            //    int mul = i * Number;
            //    Console.WriteLine(mul);
            //}


            #endregion

            #region  8- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine(" Please Enter Number : ");
            //int Number =int.Parse(Console.ReadLine() ?? string.Empty);
            //for (int i = 1; i <= Number; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);

            //}
            #endregion

            #region 9- Write a program that takes two integers then prints the power.
            //Console.WriteLine("Please enter Number then Enter Power : ");
            //int number = int.Parse(Console.ReadLine() ?? string.Empty);
            //int power = int.Parse(Console.ReadLine() ?? string.Empty);
            //int result = 1;
            //while (power != 0)
            //{
            //    result *= number;
            //    power --;
            //}
            //Console.WriteLine(result);
            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            // Console.WriteLine("Please enter Five Numbers  : ");
            /// you can make input by using loop but loop take more than steps but more effictivie for maintaince 
            //int sum = 0;
            //double Avarage = 0.0, precentage = 0.0;

            //for (int i = 0; i < 5; i++)
            //{
            //    int number = int.Parse(Console.ReadLine() ?? string.Empty);
            //    sum += number;

            //}
            //Avarage = sum / 5;
            //precentage = sum / 5 * 100 / 100;
            //Console.WriteLine($"Summation of this numbers = {sum} ");
            //Console.WriteLine($"Avarage of this numbers = {Avarage} ");
            //Console.WriteLine($"perecentage of this numbers = {precentage} ");
            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Please enter Number of Month : ");
            //int MonthNumber = int.Parse(Console.ReadLine() ?? string.Empty);

            //// function to get days of month  
            //static int GetDaysInMonth(int month)
            //{
            //    // Array to store the number of days in each month started with zero to array started with zero and months started with 1
            //    int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            //    // Return the number of days for the given month
            //    return daysInMonth[month];
            //}

            //// Validate the input
            //if (MonthNumber >= 1 && MonthNumber <= 12)
            //{
            //    int daysInMonth = GetDaysInMonth(MonthNumber);
            //    Console.WriteLine($"Number of days in month {MonthNumber}: days {daysInMonth}");
            //}
            //// invalidate input
            //else
            //{
            //    Console.WriteLine("Invalid month number, Please enter a number between 1 and 12.");
            //}

            #endregion

            #region 12- Write a program to create a Simple Calculator.
            //while (true)
            //{
            //    Console.WriteLine("simple calculator");
            //    Console.WriteLine("1- Addition");
            //    Console.WriteLine("2-Subtraction");
            //    Console.WriteLine("3-Multiplication");
            //    Console.WriteLine("4-Divion");
            //    Console.WriteLine("5-Exit");
            //    Console.WriteLine("Enter Number 1->5");
            //    Console.WriteLine(" ");
            //    int choice =int.Parse(Console.ReadLine()?? string.Empty);
            //    if (choice == 5) { Console.WriteLine("Exiting the calculator. Goodbye!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter the first Number for operation  :");
            //        int FirstNumber = int.Parse(Console.ReadLine() ?? string.Empty);
            //        Console.WriteLine("Enter the Second Number for operation :");
            //        int SecondNumber = int.Parse(Console.ReadLine() ?? string.Empty);

            //        switch (choice)
            //        {
            //            case 1:
            //                int sum = 0;
            //                sum = FirstNumber + SecondNumber;
            //                Console.WriteLine($"Addition of two numbers ={sum}");
            //                Console.WriteLine(" ");
            //                break;
            //            case 2:
            //                int sub = 0;
            //                { sub = FirstNumber - SecondNumber; }
            //                Console.WriteLine($"Subtraction of two numbers ={sub}");
            //                Console.WriteLine(" ");
            //                break;
            //            case 3:
            //                int mul = 1;
            //                mul = FirstNumber * SecondNumber;
            //                Console.WriteLine($"Multiplication of two numbers ={mul}");
            //                Console.WriteLine(" ");
            //                break;
            //            case 4:
            //                Double Div = 0;
            //                if (SecondNumber != 0)
            //                {
            //                    Div = FirstNumber / SecondNumber;
            //                    Console.WriteLine($"Division of two numbers ={Div}");
            //                    Console.WriteLine(" ");
            //                }
            //                else { Console.WriteLine("Error: Division by zero is not allowed."); }
            //                break;
            //            default:
            //                Console.WriteLine("Invalid choice, Please enter a number between 1 and 5.");
            //                break;

            //        }
            //    }


            //}
            #endregion

            #region 13- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Please Enter Your String : ");
            //string? ward= Console.ReadLine();
            //string reversedString = new string(ward.Reverse().ToArray());
            //Console.WriteLine($"Reverse of input string  {reversedString}");


            #endregion

            #region 14- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Please Enter Your integerInput : ");
            //int inputNumber =int.Parse(Console.ReadLine());
            //// Convert the integer to a string and use the Reverse method
            //string reversedString = new string(inputNumber.ToString().ToCharArray().Reverse().ToArray());

            //// Convert the reversed string back to an integer
            //int reversedNumber = Convert.ToInt32(reversedString);
            //Console.WriteLine($"ReversedNumber of Input = {reversedNumber}");


            #endregion

            #region 15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //static bool IsPrime(int number)
            //{
            //    if (number < 2) return false;
            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)  { return false; }
            //    }
            //    return true;
            //}

            //Console.WriteLine("Enter starting number of range :");
            //int StartNumber = int.Parse(Console.ReadLine() ?? string.Empty);
            //Console.WriteLine("Enter Ending number of range :");
            //int EndNumber = int.Parse(Console.ReadLine() ?? string.Empty);
            //int[] array ;
            //Console.Write("The prime number between 1 and 50 are :  [ ");

            //for (int i = StartNumber; i <= EndNumber; i++)
            //{

            //    if (IsPrime(i))
            //    {

            //        Console.Write($"{i} ");

            //    }
            //    else { continue; }

            //}

            //Console.WriteLine(" ]");

            #endregion

            #region 16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.WriteLine("Enter Decimal Number : ");
            //decimal number = Convert.ToDecimal(Console.ReadLine());
            //string BinaryNumber ="";
            //if (number == 0) { BinaryNumber = "0000";  }
            //int num= Convert.ToInt32(number);
            //while (num > 0) 
            //{

            //    int remainder = num % 2 ; // 1
            //    num = num / 2; // 12
            //    BinaryNumber = remainder + BinaryNumber ; // 1

            //}


            //Console.WriteLine($"Binary Number of input Decimal {number} is  : {BinaryNumber}");
            #endregion

            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Please Enter Points by this Syntax (x , y) ");
            //Console.WriteLine(" Enter X1 of First point ");
            //double X1=Double.Parse(Console.ReadLine());
            //Console.WriteLine(" Enter Y1 of First point ");
            //double Y1 = Double.Parse(Console.ReadLine());
            //Console.WriteLine(" Enter X2 of Second point ");
            //double X2 = Double.Parse(Console.ReadLine());
            //Console.WriteLine(" Enter Y2 of Second point ");
            //double Y2 = Double.Parse(Console.ReadLine());
            //Console.WriteLine(" Enter X3 of Third point ");
            //double X3 = Double.Parse(Console.ReadLine());
            //Console.WriteLine(" Enter Y3 of Third point ");
            //double Y3 = Double.Parse(Console.ReadLine());


            //// calculate slope to ensure that points on straight line
            //// point 3 with 2
            //double slope1 = (Y3 - Y2) / (X3 - X2);
            //double slope2 = (Y2 - Y1) / (X2 - X1);

            //if (slope1 == slope2)
            //    Console.WriteLine($"these points lie on a single straight line.P1 ({X1},{Y1}) P2 ({X2},{Y2}) P3 ({X3},{Y3})");
            //else Console.WriteLine($"these points Don't lie on a single straight line.");


            #endregion

            #region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            ////-If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            ////- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            ////- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            ////- If the worker takes more than 5 hours, they are required to leave the company. To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            //Console.WriteLine("Please Enter Time Taken for completed Task : ");
            //double takenTime=double.Parse(Console.ReadLine());
            //string efficiencyLevel = "";
            //switch (takenTime)
            //{
            //    case double when takenTime >= 2 && takenTime <= 3:
            //        efficiencyLevel = "they are considered highly efficient";
            //        Console.WriteLine(efficiencyLevel);
            //        break;
            //    case double when takenTime >= 3 && takenTime <= 4:
            //        efficiencyLevel = "they are instructed to increase their speed";
            //        Console.WriteLine(efficiencyLevel);
            //        break;
            //    case double when takenTime >= 4 && takenTime <= 5:
            //        efficiencyLevel = "they are provided with training to enhance their speed";
            //        Console.WriteLine(efficiencyLevel);
            //        break;

            //    case   > 5:
            //        efficiencyLevel = "they are required to leave the company";
            //        Console.WriteLine(efficiencyLevel);
            //        break;
            //    default: Console.WriteLine("Invalid Input"); break;

            //}
            #endregion

            #region 19- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.WriteLine("Please Enter Size of Matrix");
            //int n =int.Parse(Console.ReadLine());
            //if (n == 0) { Console.WriteLine("Please enter a positive integer greater than 0."); }
            //else
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //                Console.Write(" 1 ");
            //            else
            //                Console.Write(" 0 ");
            //        }
            //        Console.WriteLine();

            //    }
            //}

            #endregion



            #endregion


        }
    }
}
