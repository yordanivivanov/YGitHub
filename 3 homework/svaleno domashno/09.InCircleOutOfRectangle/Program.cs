﻿//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of
//the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int x = 1;
        int y = 4;
        int absoluteX = Math.Abs(x - 1);
        int absoluteY = Math.Abs(y - 1);
        bool checkInCircle = Math.Sqrt((absoluteX * absoluteX) + (absoluteY * absoluteY)) <= 3; //3 is the radius
        bool checkInRectangle = (x <= 5 && x >= -1 && y <= 1 && y >= -1);
        if (checkInCircle && checkInRectangle)
        {
            Console.WriteLine("The point is in the cirlce and in the rectangle");
        }
        if (!checkInCircle && checkInRectangle)
        {
            Console.WriteLine("The point is not in the cirlce and in the rectangle");
        }
        if (checkInCircle && !checkInRectangle)
        {
            Console.WriteLine("The point is in the cirlce and not in the rectangle");
        }
        if (!checkInCircle && !checkInRectangle)
        {
            Console.WriteLine("The point is not in the cirlce and not in the rectangle");
        }
    }
}