using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Assg2_C_
{
    class Person { public String Name; }
    internal class Program
    {
        static void Main()
        {
            #region Assignment2
            #region 1-	Write a program that allows the user to enter a number then print it
            //Console.Write("Please Enter Number :");
            //int number = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.Beep(483,2000);
            //Console.WriteLine(number);
            #endregion

            #region 2-	Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //Console.Write("Please Enter InputString :");
            //String inputString = Console.ReadLine();
            //if (int.TryParse(inputString, out int result))
            //{
            //    Console.WriteLine($"conversion successfully ,Result of Conversion : {result}");
            //}
            //else {
            //    Console.WriteLine("conversion Failed because string contains non-numeric characters");
            //}
            #endregion

            #region 3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float number01 = 15.5f, number02 =5.5f ;
            ////Addition
            //float sum = number01 + number02;
            //Console.WriteLine($"Addition : {number01} +{number02} = {sum}");

            ////Subtraction
            //float sub = number01 - number02;
            //Console.WriteLine($"Subtraction : {number01} - {number02} = {sub}");

            ////Multiplication
            //float mul = number01 * number02;
            //Console.WriteLine($"Multiplication : {number01} * {number02} = {mul}");

            ////Division
            //float Div = number02 / number01;
            //Console.WriteLine($"Division : {number02} / {number01} = {Div}");
            #endregion

            #region  4-	Write C# program that Extract a substring from a given string.
            //Console.Write("Please Enter MyString : ");
            //String myString = Console.ReadLine();
            //String subString= myString.Substring(0,5);
            //Console.WriteLine($"orginalString : {myString}");
            //Console.Write($"SubString : {subString}");
            #endregion

            #region 5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //Console.WriteLine("Please Enter Number ");
            //int Number = int.Parse(Console.ReadLine());
            //int CopyNumber = Number;
            //// updated number
            //Number += 10;
            //Console.WriteLine($"OriginalNumber : {Number}" );
            //Console.WriteLine($"CopyNumber still have first value of orginalNumber not effected with Updated : {CopyNumber}");
            #endregion

            #region 6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Person p1= new Person();
            //Person p2= new Person();
            //p1.Name = "Ahmed";
            //p2 = p1;
            //p1.Name = "Mohamed";

            //Console.WriteLine($"Person 1 Name: {p1.Name}");
            //Console.WriteLine($"Person 2 Name: {p2.Name}");//p2 effected by person1

            #endregion

            #region 7-	Write C# program that take two string variables and print them as one variable 
            // Console.WriteLine("Please Enter First String ");
            // String FirstString =Console.ReadLine();

            // Console.WriteLine("Please Enter Second String  ");
            // String SecondString = Console.ReadLine();

            // // first way
            // String Result  = FirstString + ' '+SecondString;    
            // Console.WriteLine("First Way By Using + operator : " + Result);

            // //second Way
            //String Result2 =String.Format("Second Way By Using composite formating : {0}  {1} " , FirstString ,SecondString );
            // Console.WriteLine(Result2);

            // // third way
            // Console.WriteLine($"third Way By Using Interpolation : {FirstString}  {SecondString}");


            #endregion

            #region 8-	Which of the following statements is correct about the C#.NET code snippet given below?
            //int d ;
            //d = Convert.ToInt32(!(30 < 20)); //  Always =t --> 1
            //Console.WriteLine(d);

            //// b)	A value 1 will be assigned to d. ---> correct Answer



            #endregion

            #region  9-	Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2); //int /int =int =6 , 13%2 = 1

            //// d)	6 1  --> correct Answer 

            #endregion

            #region 10-What will be the output of the C# code given below?

            //int num = 1, z = 5;

            //if (!(num <= 0)) //(! (1 <=0)) --> (!f)=true
            //    Console.WriteLine(++num + z++ + " " + ++z); // (num =2 + z =5 )=7 , z=6   z=z+1=7
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);


            ////d)	7 7 --> correct Answer
            #endregion

            #endregion



            #region Demo 
            #region Comment
            ///// using to make code more clean and clarification to another developer for helped to understanding my code 
            // single line of Text
            /*
             * multiple line of Text
             */
            #endregion

            #region Declartion & Value Type vs Reference Type
            #region Declartion
            //// DataType  nameOfVariable(must consider for meaning) valueOfVar Address of Var in memory
            //int Number = 5; 
            #endregion
            #region Value Type
            //int value;
            //// int : c# keyword
            ////CLR will Allocate 4 unintionalized Bytes at stack 
            //value = 6; // stored in stack frame 
            //Int32 x = 10; // int32 :BCL 
            //value = x; //copy from x to value

            //value++; // x not effected with update of  value 
            #endregion
            #region Reference Type
            //   class point { int x; int y; }
            // point p1;
            //// Declare for Reference of Type point ,p1 sepecial variable 
            //// Refering to Null
            ////4 Byte have been Allocate to stack  --> Address of p1
            ////0 Bytes have been Allocated at Heap
            //p1=new point();
            //// Allocate for required number of Bytes for object at Heap -->(8 bytes 4 int of x ,4 int of y)
            //// intialize Allocate Bytes with Default of it is in stack int =0 , string =null
            ////Reference type can refer to same or inherted from its
            //Employee = new Employee(); // Employee is class
            ////from itself
            //Employee =new Emp_dept(); // Emp_dept inhert from employee

            //Employee = new Point(); //not allowed
            #endregion

            #endregion

            #region BuiltIN inherted from Object For All & Can you override for fun and updated behavior
            //     // Object is a parent for {Struct ,Class , Enum , Interface }
            //     //1.Get Type (not allowed that updated behavior) 
            //     // return namespace.name of class
            //     //2. ToString ()
            //     // you can updated behavior 
            //       class point { public int x; public int y; }
            // public override string ToString()
            //          {
            //     // updated to can used to show data of class (point)
            //     return $"({X} ,{y})";
            //              }
            // // 3. GetHashCode()
            // // you can updated behavior 
            // class point { public int x; public int y; }
            // Point p1 = new Point();
            // Point p2 = new Point();
            // Console.WriteLine(p1.GetHashCode());
            // Console.WriteLine(p2.GetHashCode());
            //     // for each has different hash code
            ////4.Equals()
            //  // you can updated behavior
            //  // used to comparison two addresses 
            //  class point { public int x; public int y; }
            // Point p1 = new Point();
            // Point p2 = new Point();
            // Console.WriteLine(p1.Equals(p2)); // false for equal compare to addresses by using == you can modified to can compare values
            // Console.WriteLine(p1==p2);

            #endregion

            #region Object -->BuiltIN class 
            //  Object 01;
            //// Declare for Reference of Type Object ,Refering to null
            //// this Reference 01 can refer to instance from type object or from any DataType
            ////4 Bytes have been allocated at stack --> Address
            ////0 Bytes have been allocated at Heap

            //01 = new object();
            //01 = true;
            //01 = 5;
            //01 = 5.5;
            //01 = new DateTime();
            //01 = "Ahmed"; // syntax sugar
            //01 = new string("Ahmed");
            //01 = new Point();

            //object 01 = new object();
            //object 02 = new object();
            //01 = 02;  //both have same hash code

            #endregion

            #region Casting
            ////1. implicit casting 
            //// safe casting
            //int x = 10;
            //long y = x; //x is long
            ////2. Explicit casting 
            //  // unsafe casting
            //  long x1=8934563344;
            //int y = (int)x; // Garbage
            //Console.WriteLine(y); //Garbage
            //Console.WriteLine(int.MaxValue); //Garbage
            // to solve this 
            // long x1= 8934563344;
            //checked
            //{ 
            //  int y1=(int)x1;
            //    unchecked { Console.WriteLine(y1); }
            //}
            ////3.Parse
            // //--is method used for casting from string to caller DataType
            // int Age =int.Parse(Console.ReadLine());
            //double salary =double.Parse(Console.ReadLine());
            ////4.convert 
            ////-- is class containing set of methods used for casting from sepecific DataType to another
            //int Age1 = Convert.ToInt32(Console.ReadLine());
            //double salary1 = Convert.ToDouble(Console.ReadLine());
            //// 5.TryParse
            //int x;
            //bool flag;
            //do {
            //    Console.WriteLine("please Enter IntegerX");
            //    flag = int.TryParse(Console.ReadLine(), out x);
            //}
            //while (!flag);

            #endregion

            #region formating String
            ///// string is immutable Type , cannot changed ,Array of char
            /////  // Equation: 3 + 4 =7
            //int x=3 ,y =4 ;

            //// 1.Composite formating
            //string message = String.Format("Equation : {0} + {1} ={2}" ,x, y,(x+y));

            //// 2. String Interpolation
            ///// $ Manpulation operator
            //string msg = @"Equation : {x} +{y} ={x+y}";

            #endregion

            #region Operators
            #region Assignment operator
            //int x;
            //x = 4;
            //x += 2; //x=x+2
            //x -= 3; //x=x-2
            //x *= 4; //x=x*2
            //x /= 2; //x=x/2
            //x %= 2; //x=x%2
            #endregion
            #region Bitwise operator
            //Console.WriteLine(~0);
            //Console.WriteLine(false& true); // long circuit
            //Console.WriteLine(true|false); // long circuit
            #endregion
            #region Logical operator
            //Console.WriteLine(false && true); // short circuit
            //Console.WriteLine(true || false); // short circuit
            //Console.WriteLine(!false);

            #endregion
            #region Binary
            //// works on two operands(variables)
            //int sum, mul, div, sub, mod;
            //int num1 = 5, num2 = 6;
            //sum = num1 + num2;
            //sub = num1 - num2;
            //mul = num1 * num2;
            //div = num1 / num2;
            //mod = num1 % num2;
            #endregion
            #region Relational operator
            //int x =6 , y =5;
            //Console.WriteLine(x==y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x <= y);
            #endregion
            #region Ternary operaor
            //int x = 5, y = 3;
            //string message = x > y ? "x more y" : x < y ? "x less y" : "x Equal y";
            #endregion
            #region Unary operator
            //int x = 10;
            ////prefix 
            //++x;  //increment then print
            //--x;  //decrement then print

            ////postfix
            //x++; // print then increment
            //x--; // print then decrement

            #endregion

            #endregion

            #region priority & Assosiate
            ///*unary operator
            // * Round Braces
            // * *,
            // *  {* , / , %} ----> % right assosiate , other left assosiate
            // * { + , - }
            // */
            //int a = 20, b = 10, c = 15, d= 5, Equation;
            //Equation = ((a + b) * c )/ d;
            //Equation = (a + b) * c / d;
            //Equation = (a + b) * (c / d);
            //Equation = a + (b * c) / d;

            #endregion

            #endregion

        }
    }
}
