using System;

class CheckIfIntIsOddOrEven
{
static void Main()
{
    /*
    * Write an expression that checks if given integer is odd or even.
    */
    Console.WriteLine("Ener your number: ");
    long yourNuber = long.Parse(Console.ReadLine());

    if (yourNuber % 2 == 0)
    {
        Console.WriteLine("Your number is even!");
    }
    else
    {
        Console.WriteLine("Your number is odd!");
    }
}
}

