using System;
using System.Globalization;

class ATM
{
    static double GetValidAmount(string prompt)
    {
        double amount;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out amount) && amount >= 0)
            {
                return amount;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====\n");

        Console.Write("HI, WHAT IS YOUR NAME? ");
        string name = Console.ReadLine();

        Console.WriteLine($"\nWELCOME {name.ToUpper()}!");

        double balance = GetValidAmount("Enter account balance: ");
        double withdrawal = GetValidAmount("Enter withdrawal amount: ");

        if (withdrawal > balance)
        {
            Console.WriteLine("\nInsufficient funds!");
        }
        else
        {
            balance -= withdrawal;

            Console.WriteLine("\nWithdrawal successful!");

            CultureInfo culture = new CultureInfo("fr-FR");

            Console.WriteLine($"Updated Balance: {balance.ToString("N2", culture)}");
            Console.WriteLine($"Transaction Time: {DateTime.Now:dd MMM yyyy HH:mm:ss}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}