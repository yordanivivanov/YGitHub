using System;
 
class PrintTheSumOfNumbers
{
    static void Main()
    {
        // Write a program that reads 3 integer numbers from the console and prints their sum.

        Console.WriteLine("Please enter 3 numbers: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        Console.Write("The sum of teh three numbers is: ");
        Console.WriteLine(number1 + number2 + number3);
    }
}

