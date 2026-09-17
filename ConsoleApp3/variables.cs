using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C# programming with .Net framework");

            //Console.Write("Enter your name:");
            //string name = Console.ReadLine(); // always return string

            //Console.WriteLine($"Hello {name}! Nice to meet you!"); // String interpolation

            // Integer - int a (32-bit)
            // Double - double price
            // Float - float pi
            // Decimal - decimal amount
            // Boolean - bool isPasses = true;
            // Character - char grade = 'A';
            // String - string name = "John"

            //double x = 9.7;
            //int y = (int)x;  // Casting(Explicit conversion)

            //string input = "25";
            //int number = Convert.ToInt32(input); // return 0
            //int number2 = int.Parse(input); // throws an error

            //const double pi = 3.14159; // value never change


            // Practice question:
            //int age = 21;
            //double CGPA = 7.5;
            //string full_name = "John Doe";
            //bool isHosteler = true;

            Console.Write("Enter number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            float sum = num1 + num2;
            float avg = sum / 2;

            Console.WriteLine($"Sum: {num1 + num2}");
            Console.WriteLine($"Difference: {num1 - num2}");
            Console.WriteLine($"Product: {num1 * num2}");
            Console.WriteLine($"Average: {avg}");

            const double CollegeFeePerSem = 65000;
            Console.WriteLine($"Your fee for 8 semesters will be: {CollegeFeePerSem * 8}");
            Console.Read();


        }
    }
}