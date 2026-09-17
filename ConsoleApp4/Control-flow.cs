using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if/ else if/ else
            //int marks = 75;

            //if (marks >= 90)
            //{
            //    Console.WriteLine("Grade A");
            //}
            //else if (marks >= 75)
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (marks >= 40)
            //{
            //    Console.WriteLine("Grade C");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            //// Nested if:
            //if (isLoggedIn)
            //{
            //    if (isAdmin)
            //    {
            //        Console.WriteLine("Admin Dashboard");
            //    }
            //    else { Console.WriteLine("User Dashboard");}

            //// Switch case:
            //Console.Write("Enter day number (1-7): ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 6:
            //    case 7:                                  // stacked cases = OR
            //        Console.WriteLine("Weekend!");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day");
            //        break;
            //}

            // switch expression:
            //string dayName = day switch
            //{
            //    1 => "Monday",
            //    2 => "Tuesday",
            //    6 or 7 => "Weekend",
            //    _ => "Invalid"
            //};

            Console.WriteLine("Enter your name:");
            string StudentName = Console.ReadLine();

            Console.WriteLine("Enter maths marks:");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter physics marks:");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter chemistry marks:");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            // VAlidation
            if (maths < 0 || maths > 100 ||
                    physics < 0 || physics > 100 ||
                    chemistry < 0 || chemistry > 100)
            {
                Console.WriteLine("Error: marks must be between 0 and 100.");
            }
            else
            {
            int total = maths + physics + chemistry;
            //int percentage = total / 3;
            double percentage = (double)total / 3;

            string grade;
                if (percentage >= 90) grade = "A+";
                else if (percentage >= 80) grade = "A";
                else if (percentage >= 70) grade = "B";
                else if (percentage >= 60) grade = "C";
                else if (percentage >= 40) grade = "D";
                else grade = "FAIL";

                Console.WriteLine("\n ------Result------");
                Console.WriteLine($"Name: {StudentName} \n" +
                    $"Total marks: {total}/300 \n" +
                    $"Percentage: {percentage:F2} \n" +
                    $"Grade: {grade}");

                //string remark = grade switch
                //{
                //    "A+" => "Outstanding",
                //    "A" or "B" => "Great Job",
                //    "C" or "D" => "Keep working",
                //    _ => "Needs serious improvement"
                //};
                //Console.WriteLine($"Remark: {remark}");

                string remark;
                switch (grade)
                {
                    case "A+":

                        Console.WriteLine("Outstanding!");
                        break;

                    case "A":
                    case "B":

                        Console.WriteLine("Great Job!");
                        break;

                    case "C":
                    case "D":

                        Console.WriteLine("Keep working!");
                        break;

                    case "FAIL":

                        Console.WriteLine("Needs serious improvement");
                        break;
                }

            }
         }
    }
}
