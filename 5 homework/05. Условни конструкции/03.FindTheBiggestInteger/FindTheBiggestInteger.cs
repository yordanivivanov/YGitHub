using System;

class FindTheBiggestInteger
{
    static void Main()
    {
        //Write a program that finds the biggest of three integers using nested if statements.

        Console.WriteLine("Please inute three integers: ");

        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        if ((number1 >= number2) && (number1 >= number3))
        {
            Console.WriteLine("The bigest integer is {0}.", number1);
        }
        else if ((number2 >= number1) && (number2 >= number3))
        {
            Console.WriteLine("The bigest integer is {0}.", number2);
        }
        else if ((number3 >= number1) && (number3 >= number2))
        {
            Console.WriteLine("The bigest integer is {0}.", number3);
        }
        else
        {
        }

    }
}