using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Triangle Type Identifier ===");
        Console.WriteLine("Type 'exit' at any time to quit.");

        while (true)
        {
            Console.Write("\nEnter side 1: ");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "exit") break;

            Console.Write("Enter side 2: ");
            string input2 = Console.ReadLine();
            if (input2.ToLower() == "exit") break;

            Console.Write("Enter side 3: ");
            string input3 = Console.ReadLine();
            if (input3.ToLower() == "exit") break;

            double side1, side2, side3;
            if (double.TryParse(input1, out side1) &&
                double.TryParse(input2, out side2) &&
                double.TryParse(input3, out side3))
            {
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    Console.WriteLine("Sides must be greater than zero.");
                    continue;
                }

                if (side1 + side2 > side3 &&
                    side1 + side3 > side2 &&
                    side2 + side3 > side1)
                {
                    if (side1 == side2 && side2 == side3)
                        Console.WriteLine("This is an Equilateral triangle.");
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                        Console.WriteLine("This is an Isosceles triangle.");
                    else
                        Console.WriteLine("This is a Scalene triangle.");
                }
                else
                {
                    Console.WriteLine("These sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
