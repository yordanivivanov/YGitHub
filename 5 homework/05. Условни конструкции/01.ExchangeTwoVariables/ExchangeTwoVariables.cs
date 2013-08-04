using System;

class ExchangeTwoVariables
{
    static void Main()
    {
        // Write an if statement that examines two integer variables 
        // and exchanges their values if the first one is greater than the second one.

        Console.WriteLine("Please enter your first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your secound number: ");
        int number2 = int.Parse(Console.ReadLine());

        int var1 = 0;

        if (number1 > number2)
        {
            var1 = number1;
            number1 = number2;
            number2 = var1;

            Console.WriteLine("After the exchanging the value of the first number is {0} and the value of the secound number is {1}.",number1, number2);
        }
        else if (number1 < number2)
        {
            Console.WriteLine("The secound number is greater than the first one.");
        }
        else
        {
            Console.WriteLine("Both numbers are equal.");
        }
    }
}
