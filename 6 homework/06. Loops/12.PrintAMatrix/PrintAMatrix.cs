using System;

class PrintAMatrix
{
    static void Main()
    {
        //Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix.

        Console.Write("Enter a number N: ");
        int numberN = int.Parse(Console.ReadLine());

        for (int i = 0; i <= numberN; i++)
        {
            for (int j = 1 + i; j <= numberN + i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
