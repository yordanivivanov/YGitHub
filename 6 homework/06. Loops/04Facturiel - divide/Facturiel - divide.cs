using System;
using System.Numerics;

class FacturielDivide
{
    static void Main()
    {
        //Write a program that calculates N!/K! for given N and K (1<K<N).

        Console.WriteLine("Enter two numbers: K and N (1<K<N): ");
        int numberK = int.Parse(Console.ReadLine());
        int numberN = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        if (numberK <= 1 || numberN <= numberK)
        {
            Console.WriteLine("Error! Please eneter corect numbers.");
        }

        for (int i = numberK + 1; i < numberN; i++)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }
}