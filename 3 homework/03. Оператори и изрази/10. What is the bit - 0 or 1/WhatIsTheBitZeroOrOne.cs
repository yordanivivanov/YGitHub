using System;

class WhatIsTheBitZeroOrOne
{
    static void Main()
    {
        /*
         * Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.
         */
        Console.WriteLine("Please enter number V:");
        int numberV = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter position P of the bit which we want to know: ");
        int positionP = int.Parse(Console.ReadLine());
       
        int mask = (1 << positionP);

        int maskRresult = numberV & mask;

        int newValue = maskRresult >> positionP;
        
        bool finalResult = (newValue == 1);

        if (finalResult == true)
        {
            Console.WriteLine("The bit at position P is 1.");
        }
        else
        {
            Console.WriteLine("The bit at position P is 0.");
        }
    }
}
