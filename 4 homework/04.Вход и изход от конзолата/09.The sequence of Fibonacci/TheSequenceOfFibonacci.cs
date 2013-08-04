using System;
using System.Numerics;

class TheSequenceOfFibonacci
{
    static void Main()
    {
        //9. Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
        
        BigInteger firstNum = 0;
        Console.WriteLine(firstNum);
        BigInteger secondNum = 1;
        Console.WriteLine(secondNum);
        BigInteger sum = 1;
        Console.WriteLine(sum);

        for (BigInteger i = 2; i < 10; i++)
        {
            sum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = sum;
            Console.WriteLine(sum);
        }
    }
}