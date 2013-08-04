using System;

class ModifyBit
{
    static void Main()
    {
        /*  We are given integer number n, value v (v=0 or 1) and a position p. 
         * Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
      Example: n = 5 (00000101), p=3, v=1  13 (00001101)
      n = 5 (00000101), p=2, v=0  1 (00000001) */

        Console.WriteLine("Please enter number N:");
        int numberN = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter value V: 0 or 1");
        int valueV = int.Parse(Console.ReadLine());

        bool getValue = (valueV == 1) || (valueV == 0);
        if (getValue == true)
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Error! Please enter value V = 0 or 1!");
            return;
        }

        Console.WriteLine("Please enter the position P of value V");
        int positionP = int.Parse(Console.ReadLine());

        if (valueV == 1)
        {
            int mask = valueV << positionP;

            int result = numberN | mask;

            Console.WriteLine(result);
        }
        else
        {
            valueV = 1;
            int mask = ~(valueV << positionP);

            int result = numberN & mask;

            Console.WriteLine(result);
        }
    }
}