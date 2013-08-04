using System;

class CheckForPrimeNumber
{
    static void Main()
    {
        /*
         * Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
         */
        Console.WriteLine("Checks if given positive integer number n (n ≤ 100) is prime?");

        int number = int.Parse(Console.ReadLine());

        bool check1 = (number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0) || (number == 2) || (number == 3) || (number == 5) || (number == 7);

        Console.WriteLine(check1);

        if (check1 == true)
        {
            Console.WriteLine("The number is prime.");
        }
        else
        {
            Console.WriteLine("The number in NOT prime.");
        }
    }
}

