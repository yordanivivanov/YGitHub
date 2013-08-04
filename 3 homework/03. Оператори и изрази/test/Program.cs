using System;
 
class Program
{
    static void Main(string[] args)
    {
        /*
            * Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
            */
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int position1 = 3;
        int position2 = 24;

        int mask1 = 7 << position1;
        int resut1 = number & mask1;
        int newValue1 = resut1 >> position1;
        Console.WriteLine(newValue1);

        int mask2 = 7 << position2;
        int result2 = number & mask2;
        Console.WriteLine(result2);
        int newValue2 = result2 >> mask2;
        Console.WriteLine(newValue2);


        int change = (number | ~mask1) | mask2;
        int newNumb = (change & mask1) & mask2;
        Console.WriteLine(newNumb);


    }
}

