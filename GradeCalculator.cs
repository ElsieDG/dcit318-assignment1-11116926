using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Grade Calculator ===");
        Console.Write("Enter your numerical grade (0 - 100): ");

        // Read input and convert to integer
        string input = Console.ReadLine();
        int grade;

        // Validate input
        if (int.TryParse(input, out grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                // Determine letter grade
                string letterGrade;

                if (grade >= 90)
                    letterGrade = "A";
                else if (grade >= 80)
                    letterGrade = "B";
                else if (grade >= 70)
                    letterGrade = "C";
                else if (grade >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";

                Console.WriteLine($"Your letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
