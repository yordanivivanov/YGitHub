using System;
 
class PrintsNumbersInInterval
{
    static void Main()
    {
        // Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
        // each on a single line.

        Console.WriteLine("Entrer a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
           Console.WriteLine("{0} ", i); 
        }
        Console.WriteLine(); 
    }
}

