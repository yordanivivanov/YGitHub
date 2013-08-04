using System;

class ToStringsInTwoDifferentWays
{
    static void Main(string[] args)
    {
        Console.WriteLine(new string('-', 50));

        Console.WriteLine("First variant:");
        string firstWay = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstWay);

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Second variant:");
        string secondWay = @"The ""use"" of quotations causes difficulties(2).";
        Console.WriteLine(secondWay);

        Console.WriteLine(new string('-', 50));
    }
}

