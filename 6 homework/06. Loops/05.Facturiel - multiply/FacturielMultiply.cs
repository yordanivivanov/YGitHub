using System;
using System.Numerics;
 
    class FacturielMultiply
    {
        static void Main()
        {
            // Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

            Console.Write("Please enter n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter x= ");
            int x = int.Parse(Console.ReadLine());

            decimal resultX = 1;
            decimal factorialN = 1;
            decimal sum = 0;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                resultX *= x;
                sum += (factorialN / resultX);
            }
            Console.WriteLine(1 + sum);
        }
    }
