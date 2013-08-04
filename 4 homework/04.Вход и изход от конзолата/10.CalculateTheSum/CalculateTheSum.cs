using System;

class CalculateTheSum
{
    static void Main()
    {
        // Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

        decimal sum = 1m;
        decimal previousSum = 1m;
        decimal counter = 2m;

        do
        {
            previousSum = sum;
            if (counter % 2 == 0)
            {
                sum += (decimal)1 / counter;
            }
            else
            {
                sum -= (decimal)1 / counter;
            }
            counter++;
        } while (Math.Abs(sum - previousSum) >= (decimal)0.001m);
        
        Console.WriteLine("{0:0.000}", sum);
    }
}
