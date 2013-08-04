using System;
using System.Drawing;

class IfPointIsWithinCercleAndRect
{
    static void Main()
    {
        /*
         * Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
         * and out of the rectangle R(top=1, left=-1, width=6, height=2).
         */

        Console.Write("Please enter x= ");
        string strX = Console.ReadLine();
        double pointX = double.Parse(strX);
        Console.Write("Please enter y= ");
        string strY = Console.ReadLine();
        double pointY = double.Parse(strY);
        double radius = 3;
        double centerX = 1;
        double centerY = 1;

        bool withinCircle = ((pointX - centerX) * (pointX - centerX)) + ((pointY - centerY) * (pointY - centerY)) <= (radius * radius);
        bool withinRectangle = ((pointX >= 1 && pointX <= 7) && (pointY <= -1 && pointX >= -3));

        if (withinCircle == true && withinRectangle == false)
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle and outside of the rectangle", pointX, pointY);
        }
        if (withinCircle == true && withinRectangle == true)
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle and within of the rectangle", pointX, pointY);
        }
        if (withinCircle == false && withinRectangle == true)
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is outside the circle and within of the rectangle", pointX, pointY);
        }
        if (withinCircle == false && withinRectangle == false)
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is outside the circle and outside the rectangle", pointX, pointY);
        }
    }
}
