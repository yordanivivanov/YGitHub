using System;

class CalculatesTrapezoidsArea
{
    static void Main()
    {
        /*
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
        Console.WriteLine("Please enter side A: ");
        int sideA = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter side B: ");
        int sideB = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter side high H: ");
        int highH = int.Parse(Console.ReadLine());

        Console.WriteLine(((sideA + sideB) / 2) * highH);
    }
}

