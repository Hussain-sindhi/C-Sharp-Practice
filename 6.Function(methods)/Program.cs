using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Function_methods_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Methods(functions): reusable block of code
            // wrap the logic once and callit whenever needed.

            // No return value:
            void Greet(string name)
            {
                Console.WriteLine($"Hello, {name}!");
            }
            Greet("Rahul");   // calling it



            // With return value:
            int Add(int a, int b)
            {
                return a + b;
            }
            int result = Add(5, 10);
            Console.WriteLine(result);



            // Parameter: variable name in the method definition(a,b)
            // Argument: actual value you pass when calling it(5,10)

            // Method Overloading: same method name, different parameter lists
        }

            int Sub(int a, int b) => a-b;
            double Sub(double a, double b) => a-b;



    }
}
