using System;

class CatalanNumbers
{

    // 10. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
    // (2*n)! / (n + 1)! * n!
    // Write a program to calculate the Nth Catalan number by given N.

    // NB! Exercise 9 = Exercise 10

    static decimal FactorialCalc(decimal number)
    {
        decimal sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum = sum * i;
        }
        return sum;
    }
    static void Main()
    {
        Console.Write("Please enter a number N = ");
        decimal n = decimal.Parse(Console.ReadLine());
        decimal CatalanSum = 0;
        CatalanSum = FactorialCalc(2 * n) / (FactorialCalc(n + 1) * FactorialCalc(n));
        Console.WriteLine("The Catalan Number of number {0} is {1}", n, CatalanSum);
    }
}
