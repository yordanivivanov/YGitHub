using System;

class Program
{
    static void Main()
    {
        /*
 * Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that 
 * the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
 */

        Console.WriteLine("please input the min nuber: ");
        int minNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("please input the max nuber: ");
        int maxNumber = int.Parse(Console.ReadLine());


        int counter = 0;

        for (int i = minNumber; i <= maxNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

