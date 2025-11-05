using System;
using System.Globalization;

class MortgageCalculator
{
    static void Main()
    {
        CultureInfo bdCulture = new CultureInfo("bn-BD");

        Console.WriteLine("=== Mortgage Calculator ===");

        Console.Write("Enter loan amount (principal): ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (in %): ");
        double annualInterestRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan term (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        double monthlyRate = annualInterestRate / 100 / 12;
        int totalPayments = years * 12;

        double monthlyPayment = (principal * monthlyRate * Math.Pow(1 + monthlyRate, totalPayments)) /
                                (Math.Pow(1 + monthlyRate, totalPayments) - 1);

        double totalPaid = monthlyPayment * totalPayments;
        double totalInterest = totalPaid - principal;

        Console.WriteLine();
        Console.WriteLine($"Monthly Payment : {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Paid      : {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest  : {totalInterest.ToString("C", bdCulture)}");
    }
}
