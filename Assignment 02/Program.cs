using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //1:Write a program that takes a number from the user then print yes if 
            //that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("Enter a number: ");

            //int num = int.Parse(Console.ReadLine());

            //if (num % 3 == 0 & num % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion
            //----------------------
            #region
            //2: Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.Write("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num < 0)
            //    Console.WriteLine("negative");
            //else
            //    Console.WriteLine("positive");

            #endregion
            //----------------------
            #region
            //3: Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.Write("Enter your 1 number");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter your 2 number");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter your 3 number");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine($"MAX Number = {max}");
            //Console.WriteLine($"MIN Number = {min}");

            #endregion
            //-----------------------
            #region
            //4: Write a program that allows the user to insert an integer number then check If a number is even or odd

            //Console.Write("Enter a number: ");

            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //    Console.WriteLine("even");
            //else
            //    Console.WriteLine("odd");
            #endregion
            //-------------
            #region
            //5:Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //char ch = Convert.ToChar(Console.ReadLine());
            //switch (char.ToLower(ch))
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;

            //}
            #endregion
            //-------------------
            #region
            //6:Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            //-----------------
            #region
            //7: Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i*5);

            //}
            #endregion
            //-------------
            #region
            //8:Write a program that allows to user to insert number then print all even numbers between 1 to this number


            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(2 *i);

            //}

            #endregion
            // -----------
            #region
            //9:Write a program that takes two integers then prints the power.
            //Console.WriteLine("write your numbers");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Pow(num1, num2));

            #endregion
            //-----------------------
            #region
            //10:Write a program to enter marks of five subjects and calculate total,average and percentage.

            //int total = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"Enter The mark of {i} ");

            //    total += Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Total Subjects = {total}");
            //Console.WriteLine($"average Subjects = {total / 5}");
            //Console.WriteLine($"percentage Subjects = {(Convert.ToDouble(total) / 500) * 100} %");


            #endregion
            //----------------------------
            #region
            //11:Write a program to input the month number and print the number of days in that month

            //Console.WriteLine("Enter Month Number");
            //int month = Convert.ToInt32(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 2:
            //        Console.WriteLine("28 or 29 days");
            //        break;
            //}

            #endregion
            //------------------
            #region
            //12: Write a program to create a Simple Calculator.
            //Console.Write("Enter 1st number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char pp = Convert.ToChar(Console.ReadLine());

            //Console.Write("Enter 2nd number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //switch (pp)
            //{
            //    case '+':
            //        Console.WriteLine($"Result: {num1 + num2}");
            //        break;

            //    case '-':
            //        Console.WriteLine($"Result: {num1 - num2}");
            //        break;

            //    case '*':
            //        Console.WriteLine($"Result: {num1 * num2}");
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine($"Result: {num1 / num2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot divide by zero!");
            //        }
            //        break;
            //}
            #endregion
            //---------------------
            #region
            //13:Write a program to allow the user to enter a string and print the REVERSE of it.


            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();

            //char[] charArray = str.ToCharArray();
            //Array.Reverse(charArray);
            //string reversed = new string(charArray);

            //Console.WriteLine($"Reversed: {reversed}");
            #endregion
            //--------------
            #region
            //14- Write a program to allow the user to enter int and print the REVERSED of it.
            //            Console.Write("Enter your number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int number= 0;
            //while (num > 0)
            //{
            //    number = num % 10;
            //    Console.Write(number);
            //    num /= 10;
            //}
            #endregion
            //---------------------
            #region
            //15:- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("Input starting number of range: ");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input ending number of range: ");
            //int end = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"The prime numbers between {start} and {end} are:");
            //for (int i = start; i <= end; i++)
            //{
            //    if (i < 2) continue; 

            //    bool isPrime = true;
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.WriteLine();
            #endregion
            //---------------
            #region
            //16: Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a number to convert: ");
            //int decimalNumber = Convert.ToInt32(Console.ReadLine());
            //int temp = decimalNumber;
            //string binaryResult = "";

            //if (temp == 0) binaryResult = "0";

            //while (temp > 0)
            //{
            //    binaryResult = (temp % 2) + binaryResult; 
            //    temp /= 2;
            //}
            //Console.WriteLine($"The Binary of {decimalNumber} is {binaryResult}.");
            #endregion
            //---------------------
            #region
            //17:Create a program that asks the user to input three points (x1, y1), (x2, y2), and(x3, y3), and determines whether these points lie on a
            //single straight line.

            //Console.WriteLine("Enter x1, y1, x2, y2, x3, y3 respectively:");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //double x3 = Convert.ToDouble(Console.ReadLine());
            //double y3 = Convert.ToDouble(Console.ReadLine());

            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do NOT lie on a single straight line.");
            //}
            #endregion
            //--------------------------------
            #region
            //18:
            //Console.Write("Enter time taken by worker (in hours): ");
            //double hours = Convert.ToDouble(Console.ReadLine());

            //if (hours >= 2 && hours <= 3)
            //{
            //    Console.WriteLine("Highly efficient");
            //}
            //else if (hours > 3 && hours <= 4)
            //{
            //    Console.WriteLine("Increase speed");
            //}
            //else if (hours > 4 && hours <= 5)
            //{
            //    Console.WriteLine("Training needed");
            //}
            //else if (hours > 5)
            //{
            //    Console.WriteLine("Leave the company");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid time");
            //}

            #endregion
            //----------------
            #region
            //19:

            //Console.Write("Enter the size of the matrix (n): ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 "); 
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine(); 
            //}

            #endregion
            //------------------
            #region
            //20:
            //int[] arr = { 5, 10, 15, 20 }; 
            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine("Sum of all elements: " + sum);
            #endregion
            //------------------
            #region
            //21:
            //Console.Write("Enter size of arrays: ");

            //int n3 = int.Parse(Console.ReadLine());

            //int[] arr1 = new int[n3];
            //int[] arr2 = new int[n3];
            //int[] merged = new int[n3 * 2];

            //Console.WriteLine("Enter elements of first array:");

            //for (int i5 = 0; i5 < n3; i5++)
            //{
            //    arr1[i5] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter elements of second array:");

            //for (int i6 = 0; i6 < n3; i6++)
            //{
            //    arr2[i6] = int.Parse(Console.ReadLine());
            //}

            //for (int i7 = 0; i7 < n3; i7++)
            //{
            //    merged[i7] = arr1[i7];
            //    merged[i7 + n3] = arr2[i7];
            //}

            //Array.Sort(merged);

            //Console.WriteLine("Merged array:");

            //for (int i8 = 0; i8 < merged.Length; i8++)
            //{
            //    Console.Write(merged[i8] + " ");
            //}

            //Console.WriteLine();

            #endregion
            //------------------
            #region
            //22:Write a program in C# Sharp to count the frequency of each element of an array.

            Console.Write("Enter size of array: ");

            int n4 = int.Parse(Console.ReadLine());

            int[] arr3 = new int[n4];
            bool[] counted = new bool[n4];

            Console.WriteLine("Enter elements:");

            for (int i9 = 0; i9 < n4; i9++)
            {
                arr3[i9] = int.Parse(Console.ReadLine());
            }

            for (int i10 = 0; i10 < n4; i10++)
            {
                if (counted[i10])
                    continue;

                int count = 1;

                for (int j4 = i10 + 1; j4 < n4; j4++)
                {
                    if (arr3[i10] == arr3[j4])
                    {
                        count++;
                        counted[j4] = true;
                    }
                }

                Console.WriteLine(arr3[i10] + " occurs " + count + " time(s)");
            }
            #endregion
            //---------------------------
            #region
            //23- Write a program in C# Sharp to find maximum and minimum element in an array.
            Console.Write("Enter size of array: ");

            int n5 = int.Parse(Console.ReadLine());

            int[] arr4 = new int[n5];

            Console.WriteLine("Enter elements:");

            for (int i11 = 0; i11 < n5; i11++)
            {
                arr4[i11] = int.Parse(Console.ReadLine());
            }

            int max2 = arr4[0];
            int min2 = arr4[0];

            for (int i12 = 1; i12 < n5; i12++)
            {
                if (arr4[i12] > max2)
                    max2 = arr4[i12];

                if (arr4[i12] < min2)
                    min2 = arr4[i12];
            }

            Console.WriteLine("Maximum = " + max2);
            Console.WriteLine("Minimum = " + min2);

            #endregion
            //---------------------------------
            #region
            //24- Write a program in C# Sharp to find the second largest element in an array.
            Console.Write("Enter size of array: ");

            int n6 = int.Parse(Console.ReadLine());

            int[] arr5 = new int[n6];

            Console.WriteLine("Enter elements:");

            for (int i13 = 0; i13 < n6; i13++)
            {
                arr5[i13] = int.Parse(Console.ReadLine());
            }

            int max3 = arr5[0];
            int secondMax = arr5[0];

            for (int i14 = 1; i14 < n6; i14++)
            {
                if (arr5[i14] > max3)
                {
                    secondMax = max3;
                    max3 = arr5[i14];
                }
                else if (arr5[i14] > secondMax && arr5[i14] != max3)
                {
                    secondMax = arr5[i14];
                }
            }

            Console.WriteLine("Second largest = " + secondMax);

            #endregion

            //-------------------------------
            #region

            //25- Write a program to find the longest distance between two equal elements in an array.
            Console.Write("Enter size of array: ");

            int n7 = int.Parse(Console.ReadLine());

            int[] arr6 = new int[n7];

            Console.WriteLine("Enter elements:");

            for (int i15 = 0; i15 < n7; i15++)
            {
                arr6[i15] = int.Parse(Console.ReadLine());
            }

            int maxDistance = 0;

            for (int i16 = 0; i16 < n7; i16++)
            {
                for (int j5 = i16 + 1; j5 < n7; j5++)
                {
                    if (arr6[i16] == arr6[j5])
                    {
                        int distance = j5 - i16 - 1;

                        if (distance > maxDistance)
                            maxDistance = distance;
                    }
                }
            }

            Console.WriteLine("Longest distance = " + maxDistance);

            #endregion
            //-----------------------------------
            #region
            //26- Given a list of space separated words, reverse the order of the words.
            Console.Write("Enter a sentence: ");

            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            for (int i17 = words.Length - 1; i17 >= 0; i17--)
            {
                Console.Write(words[i17] + " ");
            }

            Console.WriteLine();
            #endregion
            //-----------------------------------
            #region
            //27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            Console.Write("Enter number of rows: ");

            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");

            int columns = int.Parse(Console.ReadLine());

            int[,] arr7 = new int[rows, columns];
            int[,] arr8 = new int[rows, columns];

            Console.WriteLine("Enter elements:");

            for (int i18 = 0; i18 < rows; i18++)
            {
                for (int j6 = 0; j6 < columns; j6++)
                {
                    arr7[i18, j6] = int.Parse(Console.ReadLine());
                }
            }

            for (int i19 = 0; i19 < rows; i19++)
            {
                for (int j7 = 0; j7 < columns; j7++)
                {
                    arr8[i19, j7] = arr7[i19, j7];
                }
            }

            Console.WriteLine("Second Array:");

            for (int i20 = 0; i20 < rows; i20++)
            {
                for (int j8 = 0; j8 < columns; j8++)
                {
                    Console.Write(arr8[i20, j8] + " ");
                }

                Console.WriteLine();
            }
            #endregion
            //------------------------------------
            #region
            //28- Write a Program to Print One Dimensional Array in Reverse Order.
            Console.Write("Enter size of array: ");

            int n8 = int.Parse(Console.ReadLine());

            int[] arr9 = new int[n8];

            Console.WriteLine("Enter elements:");

            for (int i21 = 0; i21 < n8; i21++)
            {
                arr9[i21] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array in reverse order:");

            for (int i22 = n8 - 1; i22 >= 0; i22--)
            {
                Console.Write(arr9[i22] + " ");
            }
        }
        #endregion
    }
}

            





       

    

