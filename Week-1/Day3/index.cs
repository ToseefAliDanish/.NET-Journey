using System;

namespace GradeEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grading System");
            Console.Write("Enter the student's total score: ");

            int score = Convert.ToInt32(Console.ReadLine());
            char letterGrade;

            if (score < 0 || score > 100)
            {
                Console.WriteLine("Error: Invalid score. Must be between 0 and 100.");
                return;
            }
            else if (score >= 90)
            {
                letterGrade = 'A';
            }
            else if (score >= 80)
            {
                letterGrade = 'B';
            }
            else if (score >= 70)
            {
                letterGrade = 'C';
            }
            else if (score >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            Console.WriteLine("\nFinal Grade: " + letterGrade);

            switch (letterGrade)
            {
                case 'A':
                    Console.WriteLine("Feedback: Outstanding performance!");
                    break;
                case 'B':
                    Console.WriteLine("Feedback: Good job! Solid understanding of the material.");
                    break;
                case 'C':
                    Console.WriteLine("Feedback: Average work. Room for improvement.");
                    break;
                case 'D':
                    Console.WriteLine("Feedback: Barely passed. Please review the core concepts.");
                    break;
                case 'F':
                    Console.WriteLine("Feedback: Failed. Tutoring is highly recommended.");
                    break;
                default:
                    Console.WriteLine("Error calculating feedback.");
                    break;
            }
        }
    }
}