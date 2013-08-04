using System;

class chooseTheTypeOfTheVariable
{
    static void Main()
    {
        //Write a program that, depending on the user's choice inputs int, double or string variable. 
        //If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
        //The program must show the value of that variable as a console output. Use switch statement.

        Console.WriteLine("Enter 1 for int, 2 for double and 3 for string");

        sbyte choice = sbyte.Parse(Console.ReadLine());
        Console.WriteLine("Enter your choice: ");

        switch (choice)
        {
            case 1: int firstChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(firstChoice + 1);
                break;
            case 2: double secondChoice = double.Parse(Console.ReadLine());
                Console.WriteLine(secondChoice + 1);
                break;
            case 3: string thirdChoice = Console.ReadLine();
                Console.WriteLine(thirdChoice + "*");
                break;
            default: Console.WriteLine("Your choice is not from the options");
                break;
        }
    }
}
        