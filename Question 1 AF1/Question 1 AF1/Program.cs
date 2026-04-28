using System;

class Program
{
    static double GetValidMark(string prompt)
    {
        double mark;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out mark))
            {
                return mark;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        double mark1 = GetValidMark("Enter mark for Subject 1: ");
        double mark2 = GetValidMark("Enter mark for Subject 2: ");
        double mark3 = GetValidMark("Enter mark for Subject 3: ");

        double total = mark1 + mark2 + mark3;
        double average = total / 3;

        string result = (average >= 50) ? "PASS" : "FAIL";

        Console.WriteLine("\n===== STUDENT RESULTS =====");
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Total Marks: {total}");
        Console.WriteLine($"Average Marks: {average:F1}");
        Console.WriteLine($"Result: {result}");
        Console.WriteLine($"Result Issued At: {DateTime.Now}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}