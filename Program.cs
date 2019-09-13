/*
 Author: David Salih
 Date: 9/10/2019
 Comments: This C# Console application code demonstrates the use of
            conditional statments after getting input from users
*/

using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what grade you expect to get in ISM 4300?");
            Console.WriteLine();

            try
            {
                int grade = int.Parse(Console.ReadLine());

                // if and else statment to figuer out what letter grade does the number the user provide fall in
                if ((grade >= 98) && (grade <= 100))
                {
                    Console.WriteLine("Letter grade of A+");
                }
                else if ((grade >= 92) && (grade <= 97))
                {
                    Console.WriteLine("Letter grade of A");
                }
                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.WriteLine("Letter grade of A-");
                }
                else if ((grade >= 88) && (grade <= 89))
                {
                    Console.WriteLine("Letter grade of B+");
                }
                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("Letter grade of B");
                }
                else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("Letter grade of B-");
                }
                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("Letter grade of C+");
                }
                else if ((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("Letter grade of C");
                }
                else if ((grade >= 0) && (grade < 70))
                {
                    Console.WriteLine("LETTER GRADE BELOW C, YOU ARE FALLING!! GET YOUR LIFE TOGETHER!!!");
                }
                else
                {
                    Console.WriteLine("values must not be less than 0 and not exceed 100");
                }
            }
            catch
            {
                Console.WriteLine("values must not be less than 0 and not exceed 100");
                Console.WriteLine("Press ESC to exit");
            }
        }
    }
}