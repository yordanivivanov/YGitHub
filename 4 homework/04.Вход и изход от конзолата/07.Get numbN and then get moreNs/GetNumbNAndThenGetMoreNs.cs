using System;

class GetNumbNAndThenGetMoreNs
{
    static void Main()
    {
        // Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0}: ", i);
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of all the numbers you entered is {0}.", sum);
    }
}
