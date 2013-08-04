using System;

class AllNumbersFromOneToN
{
    static void Main()
    {
        //Write a program that prints all the numbers from 1 to N.

        Console.WriteLine("Enter a number (N): ");
        int numberN = int.Parse(Console.ReadLine());

        for (int i = 1; i < numberN; i++)
        {
            Console.WriteLine(i);
        }
    }
}

