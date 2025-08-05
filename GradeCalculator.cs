using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Grade Calculator ===");
        Console.WriteLine("Type 'exit' to quit.");

        while (true)
        {
            Console.Write("\nEnter a numerical grade (0 - 100): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            int grade;
            if (int.TryParse(input, out grade))
            {
                if (grade >= 0 && grade <= 100)
                {
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

                    Console.WriteLine($"Letter grade: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number or 'exit'.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}

