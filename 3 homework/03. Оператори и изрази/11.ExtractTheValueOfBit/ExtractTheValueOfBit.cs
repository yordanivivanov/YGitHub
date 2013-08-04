using System;

class ExtractTheValueOfBit
{
    static void Main()
    {
        /*
         * Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
         */
        Console.WriteLine("Please enter number V:");
        int numberV = int.Parse(Console.ReadLine());
        int mask = (1 << 2);

        int maskRresult = numberV & mask;

        int newValue = numberV >> 2;
        Console.WriteLine(newValue);
    }
}

