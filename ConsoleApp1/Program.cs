using System;

namespace ConsoleApp1
{
    class Program
    {
        //enum DayOfWeek
        //{
        //    SUNDAY,
        //    MONDAY,
        //    TUESDAY,
        //    WEDNESDAY,
        //    THURSDAY,
        //    FRIDAY,
        //    SATURDAY
        //}

        static void Main(string[] args)
        {
            //int myInt = 555;
            //double myDouble = 5.5;
            //string myString = "Hello world";
            //bool myBool = false;
            //char myChar = 'A';
            //Console.Write(myInt);
            //Console.WriteLine(myDouble);
            //Console.WriteLine("The value of my int is {0}", myInt);
            //Console.WriteLine("I only have to say {0}", myString);
            //Console.WriteLine("Hello World!");

            //Using arithmetic operators
            //int x = 15;
            //Console.WriteLine(x);
            //int y = 20;
            //int z = x + y;
            //Console.WriteLine(z);
            //int xx = 6;
            //xx++;
            //++xx;
            //Console.WriteLine("The value of xx is {0}", xx);


            //int yy = 1;

            //int j = yy++;
            //int k = ++yy;
            //Console.WriteLine("The value of j is {0} and the value of yy is {1}", j, yy);
            //Console.WriteLine("The value of k is {0} and the value of j is {1}", k, yy);

            // Using the string data type
            //string name1 = "Jesse";
            //string name2 = "Jesse";

            //bool namesEqual = string.Equals(name1, name2);
            //Console.WriteLine(name1);
            //Console.WriteLine(namesEqual);

            //int namesCompare = string.Compare(name1, name2);
            //Console.WriteLine(namesCompare);

            //int namesCompareTo = name1.CompareTo(name2);
            //Console.WriteLine(namesCompareTo);

            //string firstCharacterOfName = name1.Substring(0, 1);
            //Console.WriteLine(firstCharacterOfName);

            //string middleSectionOfName = name1.Substring(1, 3);
            //Console.WriteLine(middleSectionOfName);

            //bool startsWith = name1.StartsWith("Jes");
            //Console.WriteLine(startsWith);


            // Numeric conversions
            //int x2 = 5;
            //double y2 = x2;

            //Console.WriteLine(y2);

            //double myDouble2 = 5.5;
            //int myInt2 = (int)myDouble;
            //Console.WriteLine(myInt2);


            // Declaring constant

            //const int myConstant = 5;
            //myConstant = 6;

            //DayOfWeek today = DayOfWeek.FRIDAY;

            //Console.WriteLine(today);
            //int numberOfToday = (int)today;
            //Console.WriteLine(numberOfToday);



            // Console Input
            //Console.WriteLine("Enter a number");
            //int number = int.Parse(Console.ReadLine());
            //number += 10;
            //Console.WriteLine("The new number is {0}", number);


            /*
             Write a program that asks the user to enter a total amount of time in minutes only.
            Print to the console the same amount of time in hours and minutes.
             */
            //const int sixty = 60;
            //Console.WriteLine("Enter the total amount of time in minutes only");
            //int totalTimeInMinutes = int.Parse(Console.ReadLine());
            //int hours = totalTimeInMinutes / sixty;
            //int remainingMinutes = totalTimeInMinutes % sixty;

            //Console.WriteLine("{0} minutes is equal to {1} hours and {2} minutes", totalTimeInMinutes, hours, remainingMinutes);

            //int age = 5;

            //if (age < 10)
            //    Console.WriteLine("You are a child");
            //Console.WriteLine("You are young");

            //if (age < 10)
            //{
            //    Console.WriteLine("child");
            //}
            //else
            //{
            //    Console.WriteLine("young");
            //}

            //int year = 2020;

            //switch (year)
            //{
            //    case (2021):
            //        {
            //            Console.WriteLine("is present");
            //            break;
            //        }
            //    case (2020):
            //        {
            //            Console.WriteLine("is last year");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Invalid");
            //            break;
            //        }
            //}

            //int x22 = 2;
            //int y22 = 3;

            //int result = x22 > y22 ? x22 : y22;
            //Console.WriteLine("The biggest is " + result);

            //double testScore = 95;
            //Console.WriteLine((testScore >= 60) ? "Pass" : "Fail");


            //int[] myArray = new int[3];
            //myArray[0] = 5;
            //myArray[1] = 6;
            //myArray[2] = 7;
            //Console.WriteLine(myArray[0]);

            // other ways to create arrays
            //int[] myArray2 = new int[3] { 5, 6, 7 };
            //int[] myArray3 = new int[] { 5, 6, 7 };
            //int[] myArray4 = { 5, 6, 7 };

            // Using loops with Arrays
            //int[] grades = { 55, 78, 86, 99, 100, 66 };
            //for(int i=0;i<grades.Length; i++)
            //{
            //    grades[i] += 3;
            //    Console.WriteLine(grades[i]);
            //}

            //foreach (int scoore in grades)
            //{
            //    Console.WriteLine(scoore);
            //}

            // Useful Array methods
            //int[] myArray22 = { 10, 15, 20, 30, 35, 40, 45 };
            //Console.WriteLine("Enter number tu check if it exists");
            //int number2 = int.Parse(Console.ReadLine());

            //int answer = Array.BinarySearch(myArray22, number2);
            //if (answer < 0)
            //{
            //    Console.WriteLine("The number does not exist");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers position in the array is {0}", answer);
            //}

            //Sorting an array
            //int[] arrayOfIntegerNumbers = { 10, 1, 11, 5, 7, 2, 55 };
            //Array.Sort(arrayOfIntegerNumbers);
            //for (int i = 0; i < arrayOfIntegerNumbers.Length; i++)
            //{
            //    Console.WriteLine(arrayOfIntegerNumbers[i]);
            //}

            //// Reverse
            //int[] reverseNumbers = { 10, 5, 7, 2, 55 };
            //Array.Reverse(reverseNumbers);
            //for(int i = 0; i < reverseNumbers.Length; i++)
            //{
            //    Console.WriteLine(reverseNumbers[i]);
            //}

            // Multidimensional Array
            //int[,] arrTwoDimensions = new int[3, 4];
            //arrTwoDimensions[0, 0] = 5;
            //arrTwoDimensions[0, 1] = 6;
            //arrTwoDimensions[0, 2] = 7;
            //arrTwoDimensions[0, 3] = 8;

            //arrTwoDimensions[1, 0] = 5;
            //arrTwoDimensions[1, 1] = 6;
            //arrTwoDimensions[1, 2] = 7;
            //arrTwoDimensions[1, 3] = 8;

            //arrTwoDimensions[2, 0] = 5;
            //arrTwoDimensions[2, 1] = 6;
            //arrTwoDimensions[2, 2] = 7;
            //arrTwoDimensions[2, 3] = 8;


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(arrTwoDimensions[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[][] myArray = new int[3][];
            //myArray[0] = new int[4] { 5, 6, 7, 8 };
            //myArray[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //myArray[2] = new int[2] { 1, 2 };

            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < myArray[i].Length; j++)
            //    {
            //        Console.Write(myArray[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            DisplayMessage();


            //Pass by value
            int answer = SumTwoNumbers(2, 2);
            Console.WriteLine("The result is {0}", answer);


            //Pass by reference
            int[] increaseNumber = new int[1];
            increaseNumber[0] = 75;
            IncreaseNumber(increaseNumber);
            Console.WriteLine("Increase Number {0}", increaseNumber[0]);


            // Ref Keyword
            int studentGrade = 75;
            GiveExtraCredit(ref studentGrade);
            Console.WriteLine(studentGrade);


            // Out Keyword
            int add;
            int mult;
            AddandMult(5, 10, out add, out mult);
            Console.WriteLine(add);
            Console.WriteLine(mult);

            // Params Keyword
            int[] myArray = { 5, 6, 7, 8 };
            PrintArray(myArray);
            PrintArray(10, 11, 12, 13, 14, 15, 16, 17);
        }

        public static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void AddandMult(int a, int b, out int added, out int mult)
        {
            added = a + b;
            mult = a * b;
        }

        public static void DisplayMessage()
        {
            Console.WriteLine("Hello world from a method");
        }

        public static int SumTwoNumbers(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }
        public static void IncreaseNumber(int[] number)
        {
            number[0] += 3;
        }
        public static void GiveExtraCredit(ref int studentGrade)
        {
            studentGrade += 3;
        }
    }
}
