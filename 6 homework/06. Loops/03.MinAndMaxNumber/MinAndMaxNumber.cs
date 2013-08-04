using System;

class MinAndMaxNumber
{
    static void Main()
    {
        // Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

        Console.WriteLine("Enter how many number you will compare: ");
        int numberN = int.Parse(Console.ReadLine());

        int Max = 0;
        int Min = 0;

        for (int i = 0; i < numberN; i++)
        {
            int var = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                Max = var;
                Min = var;
            }

            if (Max < var)
            {
                Max = var;
            }
            if (Min > var)
            {
                Min = var;
            }
        }
        Console.WriteLine("The max number is: {0} and the min number is {1}.", Max, Min);
    }
}

