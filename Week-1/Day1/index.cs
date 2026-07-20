using System;

namespace day1basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "toseef";
            char grade = 'A';         // Fixed: Single quotes for char
            int percentage = 80;      // Fixed: Integer value only
            bool isexpected = true;   // Fixed: No quotes for boolean

            Console.WriteLine("Welcome to day 1 of .NET Internship");
            Console.WriteLine("developer: " + name);
            Console.WriteLine("His grade: " + grade);
            Console.WriteLine("his percentage: " + percentage + "%"); // Added % here
            Console.WriteLine("His opinion is: " + isexpected);

            Console.Write("\nEnter your fav prog language: ");
            string primarylanguage = Console.ReadLine(); // Fixed: Capitalization
            Console.WriteLine("awesome " + primarylanguage + " is great. But C# is super power. ");
        }
    }
}