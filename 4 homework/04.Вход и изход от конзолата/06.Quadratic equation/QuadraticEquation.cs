using System;

class QuadraticEquation
{
    static void Main()
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

        Console.WriteLine("Enter value for 'a'");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for 'b'");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for 'c'");
        double c = double.Parse(Console.ReadLine());
       
        double d = b * b - (4 * a * c);
       
        Console.WriteLine("d = {0}", d);
        if (d < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        else if (d == 0)
        {
            double x = (-1 * b) / (2 * a);
            Console.WriteLine("x = {0}", x);
        }
        else
        {
            double x1 = ((-1 * b) + Math.Sqrt(d)) / (2 * a);
            double x2 = ((-1 * b) - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2= {0}", x2);
        }
    }
}