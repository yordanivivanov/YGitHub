using System;

class HowManyTrailingZerosPresent
{
    static void Main()
    {
        Console.WriteLine("This calculates the trailing zeroes in N!.");
        Console.Write("Please write N = ");
        int n = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 5; i <= n; i *= 5)
        {
            result = result + (n / i);
        }
        Console.WriteLine("Trailing zeroes of {0}! are {1}.", n, result);
    }
}


