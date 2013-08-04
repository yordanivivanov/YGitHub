using System;

class CalculatesRectangle
{
    static void Main()
    {
        /*
         * Write an expression that calculates rectangle’s area by given width and height.
        */
        Console.WriteLine("Input the width of the triangle:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the high of the triangle:");
        int hight = int.Parse(Console.ReadLine());

        int rectangle = width * hight;
        Console.WriteLine("The rectangle's aria is = {0}", rectangle);
     }
}

