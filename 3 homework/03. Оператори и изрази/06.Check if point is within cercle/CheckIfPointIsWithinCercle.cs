using System;

class CheckIfPointIsWithinCercle
{
    static void Main()
    {
        /*
         * Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
         */
        Console.WriteLine("Please enter X and Y of pointP: ");
        int pointPx = int.Parse(Console.ReadLine());
        int pointPy = int.Parse(Console.ReadLine());

        bool findPoinP = ((pointPx - 0) * (pointPx - 0) + (pointPy - 0) * (pointPy - 0) <= 5 * 5 ? true : false);

        Console.WriteLine("The pointP is within the circle: {0}", findPoinP);
    }
}

