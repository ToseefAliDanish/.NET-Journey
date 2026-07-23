using System;

namespace StudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Math marks: ");
            double mathMarks = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Physics marks: ");
            double physicsMarks = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Computer Science marks: ");
            double csMarks = Convert.ToDouble(Console.ReadLine());

            double totalMarks = mathMarks + physicsMarks + csMarks;
            double average = totalMarks / 3;

            Console.WriteLine("\n--- Report Card ---");
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Total Marks: " + totalMarks);

            Console.WriteLine("Average: " + Math.Round(average, 2) + "%");
        }
    }
}