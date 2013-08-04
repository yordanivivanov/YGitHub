using System;

class IfIntCanBeDividedBySevenAndFive
{
    static void Main()
    {
        /*
         * Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
        */
        int Number = int.Parse(Console.ReadLine());
        if (Number % 5 == 0 && Number % 7 == 0)
        {
            Console.WriteLine("Number {0} can not be divided by 7 and 5 at the same time!!", Number);
        }
        else
        {
            Console.WriteLine("Number {0} can not be divided by 7 and 5 at the same time!", Number);
        }
    }
}

