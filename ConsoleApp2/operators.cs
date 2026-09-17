using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class operators
    {
        static void Main(string[] args)
        {
            /*
            // Operators: 
            int a = 5, b = 6;
            Console.WriteLine(a / b);
            Console.WriteLine((double)a / b);

            // comparison operators;
            == != > < <=  all return bool

            // Logical operators:
            &&(AND)  ||(OR)  !(NOT)
            // bool canVote = (age>=18) && (isIndianCitizen == true);

            // Assignment operators:
            int x= 10;
            x += 5;
            x -= 3;
            x *= 2;
            x /= 4;

            // Increment/Decrement operators:
            x++;
            x--;
            */

            // Practice:
            Console.WriteLine("Enter maths marks:");
            int Maths = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter chemistry marks:");
            int Chemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter physics marks:");
            int Physics = Convert.ToInt32(Console.ReadLine());

            int Total = Maths + Chemistry + Physics;
            double Percentage = (double)Total / 3;

            Console.WriteLine($"Total: {Total}");
            Console.WriteLine($"Percentage {Percentage:F2}%");

            bool isPass = (Percentage >= 40) && (Maths >= 33) && (Chemistry >= 33) && (Physics >= 33);
            Console.WriteLine($"Result: {(isPass ? "PASS" : "FAIL")}");

        Console.WriteLine(Total%2 == 0 ? "Total is even" : "Total is odd");
            //if (Total % 2 == 0)
            //{
            //    Console.WriteLine("Total marks is an even number");
            //}
            //else
            //{
            //    Console.WriteLine("Total marks is an odd number");

            //}

        }
    }
}