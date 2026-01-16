// See https://aka.ms/new-console-template for more information
using System;

namespace Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.Write("How many dice rolls would you like to simulate? ");
        int numRolls = int.Parse(Console.ReadLine());

        RollDice roller = new RollDice();
        int[] counts = roller.SimulateRolls(numRolls);
        
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS: ");
        System.Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        System.Console.WriteLine($"Total number of rolls = {numRolls}");    
        System.Console.WriteLine();

        for (int sum = 2; sum <= 12; sum++)
        {
            int thisSum = counts[sum];
            double percentage = (double)thisSum / numRolls * 100;
            int starsCount = (int)Math.Round(percentage);
            string stars = new string('*', starsCount);
            
            System.Console.WriteLine($"{sum}: {stars}");
            System.Console.WriteLine();
        }
        
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}