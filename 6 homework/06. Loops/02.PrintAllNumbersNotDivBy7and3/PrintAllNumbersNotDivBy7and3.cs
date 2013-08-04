using System;

class PrintAllNumbersNotDivBy7and3ram
{
    static void Main()
    {
        // Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

        Console.WriteLine("Enter a number (N): ");
        int numberN = int.Parse(Console.ReadLine());

        for (int i = 1; i < numberN; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.WriteLine(i);
            }
            else
            {
            }
        }
    }
}