using System;

class ReadTheRadius
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area.

        Console.WriteLine("Please enter the radius r of the circle");
        int radiusR = int.Parse(Console.ReadLine());
        double perimeterP = 2 * Math.PI * radiusR;
        double aria = Math.PI * radiusR * radiusR;

        Console.WriteLine("The perimetr of the circle is {0} and the aria of the circle is {1}.", perimeterP, aria);
    }
}

