using System;
using System.Diagnostics;
using System.Text;
namespace Assig3_Part2_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Assignment3_part2
            #region 20- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] numbers = new int[5] {10,20,30,40,50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"Summation of Array = {sum} ");

            #endregion

            #region 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] arr01 = {3,6,9,5,8 };
            //int[] arr02 = {4,2,1,10 ,7};

            //int[] arr03 =new int[arr01.Length + arr02.Length];
            //if (arr01.Length == arr02.Length)
            //{
            //    arr03 = arr01.Concat(arr02).ToArray();
            //    Array.Sort(arr03);
            //    for (int i = 0; i < arr03.Length; i++)
            //    {
            //        Console.WriteLine(arr03[i]);
            //    }
            //}
            //else
            //    Console.WriteLine($"can not merge two array because size of two array not equal length of arr1 = {arr01.Length} , arr2 ={arr02.Length} ");



            #endregion

            #region 22- Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] array = { 3, 2, 4, 5, 6, 2, 5, 2, 1, 3, 5 };

            //Dictionary<int, int> frequency = new Dictionary<int, int>();
            //Array.Sort(array);
            //bool visited = false;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    int count = 0;
            //    if (frequency.ContainsKey(array[i]))
            //    {
            //        ++count;
            //        frequency[array[i]] +=count;
            //    }
            //    else
            //    {
            //        frequency.Add(array[i], 1);
            //    }

            //}

            //for (int i = 0; i < frequency.Count; i++)
            //{
            //    Console.WriteLine("Key " + frequency.ElementAt(i).Key + " Value " + frequency.ElementAt(i).Value);
            //}


            #endregion

            #region 23- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] array = { 3, 2, 4, 5, 6, 1, 9};
            //int max = int.MinValue, min = int.MaxValue;
            ////Console.WriteLine(int.MaxValue );

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i]<min)
            //        min = array[i];
            //    if (array[i]> max)
            //    {
            //        max = array[i];
            //    }
            //}

            //Console.WriteLine($"minimum Value of array is {min} , Maximum value of array is {max}");
            #endregion

            #region 24- Write a program in C# Sharp to find the second largest element in an array.
            //int[] array = { 3, 2, 4, 5, 6, 1, 9, 7, 9 };
            //int secendMax=int.MinValue;
            //Array.Sort(array);
            //int max =int.MinValue;

            //if (array.Length == 1)
            //{
            //    array[0] = max; Console.WriteLine(" havenot second max because array is length of 1");

            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (i > max)
            //    {
            //        secendMax = max;
            //        max = i;
            //    }
            //}

            //Console.WriteLine($"second largest element in array is {secendMax}");


            #endregion

            #region 25-. Consider an Array of Integer values with size N, having values as in this Example
            //int[] Arr;
            //Console.WriteLine("Please Enter Size Of Array");
            //int ArrSize = Convert.ToInt32(Console.ReadLine());
            //Arr = new int[ArrSize];

            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.Write($"Enter value ({i + 1}/{ArrSize}): ");
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = 0;
            //int n = 0;
            //int n1 = 0;

            //for (int x = 0; x < Arr.Length; x++)
            //{
            //    for (int j = x + 1; j < Arr.Length; j++)
            //    {
            //        if (Arr[x] == Arr[j])
            //        {
            //            n = j;
            //            n1 = x;

            //            if (n - n1 > max)
            //            {
            //                max = n - n1;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"The longest distance between equal cells: {max - 1}");
            #endregion


            #region 26- Given a list of space separated words, reverse the order of the words.
            //Console.Write("Enter a space-separated string: ");
            //string? input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //Array.Reverse(words);
            //string reservedWord = string.Join(" ", words);

            //Console.WriteLine($"Rverse text of input text ---> {reservedWord}");
            #endregion

            #region  27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.WriteLine("Enter the number of rows: ");
            //int rows= int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of cloumns: ");
            //int cloumns = int.Parse(Console.ReadLine());

            //int[,] firstArray=new int[rows,cloumns];
            //Console.WriteLine("Enter values for the first array:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cloumns; /*j++*/)
            //    {
            //        Console.WriteLine($"Element [{i+1} ,{j+1}] : ");
            //         // firstArray[i,j] =int.Parse(Console.ReadLine());
            //       bool flag = int.TryParse(Console.ReadLine(), out firstArray[i, j]);
            //        if (flag) j++;
            //    }

            //}
            //int[,] secondArray =new int[rows,cloumns];
            //Array.Copy(firstArray,secondArray,firstArray.Length);

            //Console.Clear();
            //Console.Beep(3223,3000);

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cloumns; j++)
            //    {
            //        Console.Write($"{secondArray[i, j]} ");

            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region 28- Write a Program to Print One Dimensional Array in Reverse Order

            //Console.Write("Enter the size of the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] array = new int[n];

            //Console.WriteLine("Enter values for the array:");

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array[i]= int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("\n Array in Reverse Order:");
            //for (int i = n-1; i >= 0; i--)
            //{
            //    Console.WriteLine($"{array[i]} ");
            //}

            #endregion
            #endregion




            #region Demo

            #region String
            ////string is class(Reference type) ,is array of characters
            //string Name;
            ////Declear for Reference of type "string"
            ////this Referene 'Name' is Refering to the default value of Reference Type =NULL
            ////CLR will allocate ---> 4 Bytes at stack for reference 'name'
            ////              ---->0 Bytes at Heap 
            //Name = new string("Ahmed"); //CLR will allocate 10 bytes at heap
            //Name = "Ahmed"; //syntax sugar

            //Console.WriteLine(Name);
            //Console.WriteLine($"HashCode = {Name.GetHashCode()}");
            //         **************************************Example
            //string Name01 = "Ahmed"; /*Hash 2 references*/
            //string Name02 = "Omar"; /*UnreachableException object*/
            //Console.WriteLine($"Name01 ={Name01}");
            //Console.WriteLine($"HashCode of name01 ={Name01.GetHashCode()}");
            //Console.WriteLine($"Name02 ={Name02}");
            //Console.WriteLine($"HashCode of name02 ={Name02.GetHashCode()}");

            //Name01 = Name02; Console.WriteLine("********After Name02 =Name01***********");
            //Console.WriteLine($"Name01 ={Name01}");
            //Console.WriteLine($"HashCode of name01 ={Name01.GetHashCode()}");
            //Console.WriteLine($"Name02 ={Name02}");
            //Console.WriteLine($"HashCode of name02 ={Name02.GetHashCode()}");

            ////         **************************************Example2

            //string message = "Hello";
            //Console.WriteLine(message);
            //Console.WriteLine($"hashCode of message :  {message.GetHashCode()}");

            //message += "Ahmed";
            //Console.WriteLine("*********After message updated****************");

            //Console.WriteLine(message);
            //Console.WriteLine($"hashCode of message :  {message.GetHashCode()}");

            #endregion

            #region StringBuilder

            //StringBuilder message;
            //////Declear for Reference of type "string builder"
            //////this Referene 'Name' is Refering to the default value of Reference Type =NULL
            //////CLR will allocate ---> 4 Bytes at stack for reference 'name'
            //////              ---->0 Bytes at Heap 
            ///// is mutable string ,internally is linked list chars
            //message = new StringBuilder("Hello");
            //Console.WriteLine(message);
            //Console.WriteLine($"hashCode of message :  {message.GetHashCode()}");
            //message.Append("Ahmed");

            //Console.WriteLine("*********After message updated****************");

            //Console.WriteLine(message);
            //Console.WriteLine($"hashCode of message :  {message.GetHashCode()}");


            #endregion

            #region String Builder methods

            //StringBuilder message = new StringBuilder("Hello");

            //message.AppendLine(" Ahmed");
            //Console.WriteLine(message);

            //message.AppendLine(" Nasr");
            //message.Append("your age is 22");
            //message.Remove(0,5); // remove hello
            //message.Insert(0,"Hi");
            //message.AppendFormat("{0},{1}", true, 'A');
            //message.Clear();
            //message.AppendJoin(';', "hassnaa", "mounir");
            //message.Length=0;
            //message.GetChunks();

            #endregion

            #region one D Array
            //int [] numbers;

            //numbers = new int[3]; // intialize array of size 3   
            //// CLR WILL allocate 12 bytes in heap ,intilize by default value of int =0
            //// make object refer of address 
            //int [] numbers02 = new int[3] { 1,2,3};
            ////or
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //int[] numbers03 = new int[] {1,2,3}; // without size will known from number of elements
            //int[] numbers04 =  {1,3,4,5}; // syntax sugar

            //// looping by using for or foreach
            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //numbers[3] = 1; // will throw exception 


            #endregion

            #region Two D Array
            //int[,] marks = new int[3,5];
            //// assign values per cell
            //marks[0,0] = 50;
            //marks[0, 1] = 40;
            //marks[0, 2] = 100;
            //marks[0, 3] = 200;
            //marks[1, 0] = 50;
            //marks[1, 1] = 40;
            //marks[1, 2] = 100;
            //marks[1, 3] = 200;

            //// another way for assign values
            //int[,] ints = new int[3, 5] { {1,2,3,4,5 },{33,34,45,33,20 },{ 10,11,12,13,14} };

            //Console.WriteLine(marks.Length); // to show length of array
            //Console.WriteLine(marks.Rank);  //to show dimention of array

            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //// pervious example have  issue
            //// if you not read integer happen problem
            //bool flag;
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < marks.GetLength(1); /*j++*/)
            //    {
            //       // marks[i, j] = int.Parse(Console.ReadLine());
            //        flag = int.TryParse(Console.ReadLine(), out marks[i,j]);
            //        if (flag) j++;
            //        // j = int.TryParse(Console.ReadLine(), out marks[i,j])? ++j :j ;
            //    }
            //}


            #endregion

            #region Array with using one loop
            //int[,] marks = new int[3,5];
            //// row = i/#of columns (array.getlength(1))
            //// columns  = i% #of columns (array.getlength(1))
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine(marks[i/marks.GetLength(1), i % marks.GetLength(1)]);
            //}
            ///////O(n)

            #endregion

            #region 2D Array --Judged Array (# of column per row not equal)

            //int[][] marks = new int[3][]; // 3 number of arraies as row
            //marks[0] =new int[3] {1,2,3};
            //marks[1] = new int[2] {3,4};
            //marks[2] = new int[1] {5};



            #endregion

            #region Array Methods
            #region class member methods (static methods)
            //// method exist based on class
            //int[] marks = new int[5] { 88, 97, 78, 50, 60 }; 
            //int[] arr =new int[3] { 2,8,4};
            //Array.Sort(arr); // sort acanding
            //Array.Copy(marks, arr, 3);
            //Array.Clear(arr);
            //Array.ConstrainedCopy(marks,1,arr,0,2);
            //int[] arr03= (int[])Array.CreateInstance(typeof(int),10);
            //int[,] arr04 = (int[,])Array.CreateInstance(typeof(int), 2, 4); //2d 2rows , 4 columns
            //Array.IndexOf(marks, 50);


            #endregion

            #region Object Member Methods(non static method) 
            //// method called based on object

            //int[] arr02 = { 1, 2, 3, 4, 5 };
            //int[] arr03 =new int[3];
            //arr02.CopyTo(arr03,1);

            //arr02.GetLength(0); //return dimenssion
            //arr02.GetValue(1);// arr02[1]
            //arr02.SetValue(100, 1);//arro2[1] =100

            #endregion
            #endregion


            #endregion





        }
    }

}