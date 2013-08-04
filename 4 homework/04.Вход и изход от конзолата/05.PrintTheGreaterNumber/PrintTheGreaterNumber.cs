using System;

class PrintTheGreaterNumber
{
    static void Main()
    {
        //  Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

        Console.WriteLine("Please enter the first number: ");
        int maxNumb = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the secound number: ");
        int minNumb = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is {0}.", maxNumb > minNumb ? maxNumb:minNumb);
                         
    }
}

