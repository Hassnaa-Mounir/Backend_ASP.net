using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace Assignment4_C_
{
    class person { public string name; }
    internal class Program
    {
       
        static void Main(string[] args)
        {

            #region Assignment4_C#

#region 1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

//// passing by value (input parameter)
//// take copy from variable of main then execute fun when function ended removeded from memory it is not effected on values of main or variable taken copy
//// example
//static void IncrementValueWithPass(int number)
//{
//    ++number;
//    Console.WriteLine($"Inside method: {number}");
//}
//int num = 5;
//IncrementValueWithPass(num);
//Console.WriteLine($"Outside method: {num}");
//// passing by Ref (input output parameter)
////take data itself of variable for main then execute fun when function ended removeded from memory it is  effected on values of main or variable taken because variable is recalling by argument of function when ended  return named of main data
//static void IncrementValueWithRef(ref int number)
//{
//    ++number;
//    Console.WriteLine($"Inside method: {number}");
//}
//int num2 = 5;
//IncrementValueWithRef(ref num2);
//Console.WriteLine($"Outside method: {num2}");


#endregion


#region  2 - Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.
//// passing by value ---> value  is type of reference type
////variable of calling for main refer on address of object ad when you call function argument refer to same address
////and any chanched in this address two object will effected with this but if make argument refer another address that is not effected on data of main 
////example for 
//static void modifiedByPassVal(person per) 
//{
//    per.name = "jak";
//    per =new person();
//    per.name = "hany";
//    Console.WriteLine($"Name inside function {per.name}");
//}

//person p1 = new person();
//p1.name= "Alian";
//modifiedByPassVal(p1);
//Console.WriteLine($"Name outside function {p1.name}");


////passing by ref
////  data of main recalled by arguments of function any chanched will effected because two object the same but with different in named
//static void modifiedByPassRef(ref person per)
//{
//    per.name = "jak";
//    per = new person();
//    per.name = "hany";
//    Console.WriteLine($"Name inside function {per.name}");
//}

//person p1 = new person();
//p1.name = "Alian";
//modifiedByPassRef(ref p1);
//Console.WriteLine($"Name outside function {p1.name}");

#endregion

#region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
//// by using passing by out 

//static void SumAndSub(int Fnum ,int Snum , out int sum,out int sub)
//{
//    sum=Fnum+Snum;
//    sub=Snum-Fnum;
//}

//int A = 4, B = 6, SUM =0, SUB = 0;
//    SumAndSub(A,B,out SUM,out SUB);
//Console.WriteLine($"sumation of two numbers = {SUM}  and subtraction of two numbers = {SUB}");
#endregion

#region 4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Output should be like
// Enter a number: 25
// The sum of the digits of the number 25 is: 7

// static int SumOfIndividualDigit(int number) 
// {
//     int sum = 0;
//     while(number > 0)
//     {
//        sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }

// bool flag;
// int input;
// do {
//     Console.WriteLine("Please Enter input Data : ");
//     flag = int.TryParse(Console.ReadLine(), out input); }
//while (!flag || input == 0);
//int result= SumOfIndividualDigit(input);

// Console.WriteLine($"sumation of individual digit =  {result}");
#endregion

#region 5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

// static string IsPrime(int number) 
// {
//     string msg =" ";
//   if (number >= 2) 
//     {
//         int count = 2;
//      while ( count <= Math.Sqrt(number) )
//         {
//             if (number % count == 0) { msg = "this Number Is Not Prime"; break;  }
//            // else msg = "this Number Is Prime number";
//             count++;
//         }
//      if(msg==" ")
//         msg = "this Number Is Prime number";

//     }
//   else msg = "this Number Is Not Prime";
//     return msg;
// }

// bool flag;
// int input;
// do
// {
//     Console.WriteLine("Please Enter input Data : ");
//     flag = int.TryParse(Console.ReadLine(), out input);
// }
// while (!flag);
//string output= IsPrime(input);
// Console.WriteLine(output);
#endregion

#region 6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
// static void MinMaxArray(ref int[] array,ref int min,ref int max) 
//{
//    min = int.MaxValue;
//    max =int.MinValue;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] > max) max = array[i];
//        if (array[i] < min) min = array[i];
//    }

//}

//int min=0, max=0;
//int[] arr = {5,9,2,7,8,6,1,3};
//if (arr?.Length > 0)
//{ MinMaxArray(ref arr, ref min, ref max); }
//Console.WriteLine($"minimum of array is {min} and maximum of array is {max}");

#endregion

#region 7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
//static int FactorialOfNumber(int number) 
//{
//    int mul = 1;
//    if (number ==0) mul = 1;
//    while (number >= 1) 
//    {
//       mul *= number;
//        number--;
//    }
//  return mul;
//}

//bool flag;
//int input;
//do
//{
//    Console.WriteLine("Please Enter input Data : ");
//    flag = int.TryParse(Console.ReadLine(), out input);
//}
//while (!flag);
//int result = FactorialOfNumber(input);
//Console.WriteLine($"Factorial of this number  {result}");

#endregion

#region 8-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

//static void ChangeChar(ref string inputLetter ,ref int position ,ref char newCharacter) 
//{
//    char[] charactersOfString = new char[inputLetter.Length];
//    charactersOfString =inputLetter.ToCharArray();
//    if (position < inputLetter.Length) 
//    {
//        charactersOfString[position] = newCharacter;
//    }
//    inputLetter =new string(charactersOfString);
//}

//Console.WriteLine("Please Enter your Letter to modified : ");
//string? input = Console.ReadLine();
//int pos;
//bool flag;
//Console.WriteLine("Please Enter NewCharacter for modified : ");
//char NewChar =Convert.ToChar( Console.ReadLine()??string.Empty);
//do
//{
//    Console.WriteLine($"Please Enter your position to modified from 0 to  {input.Length-1} : ");
//    flag = int.TryParse(Console.ReadLine(), out pos);
//}
//while (pos < 0 || !flag || pos > input.Length - 1);

//    ChangeChar(ref input, ref pos, ref NewChar);
//    Console.WriteLine($"New letter after modified : {input}");

#endregion

#endregion




#region Demo



#region Boxing vs UnBoxing
//// Boxing Example:

//object obj2;
//obj2 = 5;

//// UnBoxing Example:

//int y = (int)obj2; //(unsafe)
////Child  = Parent;

//int x = (int)obj2; //(unsafe) 
#endregion

#region Nullable Types
////Nyllable Types Example:

//int age;
//age = 22;
//age = null; // (error) Not valid
//            // Ex-1:
//int? salary;   // Nullable integer
//salary = null; // valid

//// Ex-2:
//double? value;   // Nullable integer
//salary = null; // valid 
#endregion


#region  Casting with Nullable types

//// Ex-1:
//int x = 5; // allow int values only
//int? y = x; // allow int values + Null

////compare 
//int? val = x; //implicit safe
//x = (int)val; //explicit  (unsafe casting)
//              //unsafe 

////convert value type to Nullable type

//Nullable<int> age;
//int? age2; 
#endregion

#region protective code
//int? x =0;
//int y;

//if (x.HasValue )
//{
//    y = (int)x;
//}
//else
//{
//    y = 0;
//}

////another way
//if (x != null)
//{
//    y = (int)x;
//}
//else
//{
//    y = 0;
//}
////another way
//y = x.HasValue ? x.Value : 0;

////another way
//y = x ?? 0;

#endregion

#region Nullable Types of RT

////ex:
//    String? notnull = "Hi";
//    String? Nullable = default;
//    notnull = Nullable;  //null forgiveness (!)

//    // without ? with not null 
//    notnull = Nullable!;
#endregion

#region  null propagation operator


// double x = default;
// int[] numbers = default!;
// int[] array = { };
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

// ///or

//             for (int i = 0; i < numbers?.Length; i++)
// {
//     int len = numbers != null ? numbers.Length : 0;
// }

///// or

//             if (array != null)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }



#endregion



#region Parameter of function
//1-parameter as value type


//static void swap(int x,int y)
//{
//    int tmp =x;
//    x = y;
//    y = tmp;
//}



//2-parameter as reference type


//ex:passing by value

//static int SumArr(int[]arr)
//{
//    int sum = 0;
//    for(int i = 0 ; i< arr ?.Length ; i++)
//    {
//        sum+=arr[i];
//    }
//    return sum;
//}
//there was a problem in this code where this could may send to me null  and the solution is
//static int SumArr(int[]arr)
//{
//    int sum = 0;

//    if(arr is not null){
//    for(int i = 0 ; i<arr?.Length ; i++){
//        sum+=arr[i];}


//    }
//    return sum;
//}
//arr[0] = 100;


//ex:passing by out

//static void SumMul(int x,int y,out int sum,out int mul)
//{
//    sum = x+y;
//    mul = x * y;
//}

////ex:

//int[]nums = {1,2,3,4,5,6,7};
//int sum = SumArr(1,2,3,4,5,6,7);
//Console.WriteLine("{0}+{1}+{3} ={2}{4}",10,20,35,5,"Hamada");

////ex:

//static int SumArr(int x,int y=5,params int []arr)
//{
//    int sum = 0;
//    if(arr is not null)
//    {
//        for(int i = 0 ; i< arr.Length ; i++)
//        {
//            sum += arr[i];
//        }

//    }
//    return sum;
//} 
#endregion


#region How can write Desensive or protective code?

         ////Ex: for code not handled 

         //       static void DoSomeCode()
         //       {
         //           int x,y,z;
         //           x = int.Parse(Console.ReadLine());
         //           y = int.Parse(Console.ReadLine());
         //                       z = x/y;
         //        int[] arr = { 1, 2, 3 };
         //           arr[100] = 22;    
         //       }

         ////Ex: for handled previous Ex

         //       static void protectiveCode()
         //       {
         //           int x,y,z;
         //           bool flag;
         //                       do {
         //                           Console.WriteLine("please Enter x");
         //                           flag = int.TryParse(Console.ReadLine(), out x);
         //                       } while (!flag);
         //       do
         //       {
         //           Console.WriteLine("Please enter y");
         //           flag = int.TryParse(Console.ReadLine(), out y);
         //       } while (!flag || y == 0);

         //           int[] arr = {1,2,3};
         //           if(arr?.Length >=100)
         //           {
         //               arr[100] = 22;
         //           }
    
         //       }


         //       //then

         //       try
         //       {
         //           protectiveCode();
         //       }
         //       catch(Exception ex)
         //       {
         //           Console.WriteLine(ex.Message);
         //       }
         //       finally
         //       {
         //       Console.WriteLine("Finally");
         //       }
            #endregion



            #endregion












        }
    }
}
