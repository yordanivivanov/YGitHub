using System;

class QuadraticEquation
{
    static void Main()
    {
        // Write a program that enters the coefficients a, b and c of a quadratic equation
		//a*x2 + b*x + c = 0
		//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.


        Console.WriteLine("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c; //descriminant

        double x, x1, x2;

        if (a == 0)
        {
            Console.WriteLine("One real root - x1: {0}", -c / b);
        }
        else if (d > 0)
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2 = {0}", x2);
        }
        else if (d < 0)
        {
            Console.WriteLine("No real solution!");
        }
        else if (d == 0)
        {
            x = -b / (2 * a);
            Console.WriteLine("x = {0}", x);
        }
    }
}