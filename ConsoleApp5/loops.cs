using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class loops
    {
        static void Main(string[] args)
        {
            //// For Loop:
            //for (int i = 1; i<=5; i++)
            //{
            //    Console.WriteLine($"Count: {i}");
            //}

            //// While Loop:
            //int n = 1;
            //while (n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++; // forgot this and you get an infinite loop
            //}

            //// do-while loop:
            //string input;
            //do
            //{
            //    Console.WriteLine("Type 'exit to quit:");
            //    input = Console.ReadLine();
            //} while (input != "exit");

            //// foreach Loop:
            //string[] subjects = { "Maths", "Physics", "chemistry" };
            //foreach (string subject in subjects)
            //{
            //    Console.WriteLine(subject);
            //}

            //for(int i = 1; i <= 10; i++)
            //{
            //    if (i == 5) continue;
            //    if (i == 8) break;
            //    Console.WriteLine(i);
            //}

            //// Nested Loops:
            //for (int i = 1;i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.WriteLine($"{i * j}\t");
            //    }
            //    Console.WriteLine(); // new line for each row
            //}

            // Practice:
            //Console.WriteLine("Enter value of i:");
            //int i = Convert.ToInt32(Console.ReadLine());
            //for (int j = 1; j <= 10; j++)
            //{
            //    Console.WriteLine($"{i} x {j} = {i * j}");
            //} // task 1. built table eg.(2 x 1 = 2) 




            //int choice;
            //double num1, num2, result;

            //do
            //{
            //    Console.WriteLine("\n----calculator----");
            //    Console.WriteLine("1. Add");
            //    Console.WriteLine("2. Subtract");
            //    Console.WriteLine("3. Multiply");
            //    Console.WriteLine("4. Divide");
            //    Console.WriteLine("5. Exit");

            //    Console.Write("Enter your choice: ");
            //    choice = Convert.ToInt32(Console.ReadLine());

            //    if (choice >= 1 && choice <= 4)
            //    {
            //        Console.Write("Enter first number: ");
            //        num1 = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("Enter Second number: ");
            //        num2 = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else
            //    {
            //        num1 = 0;
            //        num2 = 0;
            //    }
            //    switch (choice)
            //    {
            //        case 1:
            //            result = num1 + num2;
            //            Console.WriteLine($"Result: {result}");
            //            break;

            //        case 2:
            //            result = num1 - num2;
            //            Console.WriteLine($"Result: {result}");
            //            break;

            //        case 3:
            //            result = num1 * num2;
            //            Console.WriteLine($"Result: {result}");
            //            break;

            //        case 4:
            //            if (num2 != 0)
            //            {
            //                result = num1 / num2;
            //                Console.WriteLine($"Result: {result}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("cannot divide by zero");
            //            }
            //            break;

            //        case 5:
            //            Console.WriteLine("Exit");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid Choice!\n Please choice 1-5 option");
            //            break;
            //    }
            //} while (choice != 5);            // task 3. calculator


            //Console.WriteLine("How many numbers you want to enter: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //double sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter number {i}");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    sum += num;
            //    //sum = sum + num;
            //}

            //double avg = sum / n;
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Average: {avg}");      // task 2. sum & avg of n no.


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}      // task 2. pattern


            for (int i = 2; i <= 50; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }      // task 5
        }
    }
}