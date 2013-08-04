using System;
using System.Numerics;

class SequenceOfFibonacci
{
    static void Main()
    {
        // Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

        Console.Write("Please enter number N: ");
        int numberN = int.Parse(Console.ReadLine());

        BigInteger firstNum = 0;
        BigInteger secondNum = 1;
        BigInteger tempSum = 0;
        BigInteger result = 0;

        for (int i = 0; i < (numberN - 2); i++)
        {
            tempSum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = tempSum;
            result += tempSum;
        }
        Console.WriteLine(1 + result);
    }
}

