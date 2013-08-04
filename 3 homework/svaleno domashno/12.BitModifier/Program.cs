//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators 
//that modifies n to hold the value v at the position p from the binary representation of n.
//	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//	n = 5 (00000101), p=2, v=0  1 (00000001)
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int mask = 1<<p;
        int maskIf = (mask&n)!=0 ? 1 : 0; //determine the bit in position p

        if (maskIf==0)
        {
            Console.WriteLine(n|(1 << p));
        }
        else
        {
            Console.WriteLine(n&~(1<<p));
        }

    }
}