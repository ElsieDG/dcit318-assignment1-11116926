using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Ticket Price Calculator ===");
        Console.WriteLine("Type 'exit' to quit.");

        while (true)
        {
            Console.Write("\nEnter your age: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            int age;
            if (int.TryParse(input, out age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Age cannot be negative.");
                }
                else
                {
                    double price = (age <= 12 || age >= 65) ? 7.00 : 10.00;
                    Console.WriteLine($"Ticket Price: GHC{price:F2}");
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
