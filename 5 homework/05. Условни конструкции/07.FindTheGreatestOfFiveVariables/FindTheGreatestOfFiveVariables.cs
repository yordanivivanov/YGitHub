using System;

class FindTheGreatestOfFiveVariables
{
    static void Main()
    {
        //Write a program that finds the greatest of given 5 variables.

        {
            Console.Write("Please enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter the third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter the fourth number: ");
            double fourthNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter the fifth number: ");
            double fifthNumber = double.Parse(Console.ReadLine());

            double greaterNumber = firstNumber;

            if (greaterNumber < secondNumber)
            {
                greaterNumber = secondNumber;
            }
            if (greaterNumber < thirdNumber)
            {
                greaterNumber = thirdNumber;
            }
            if (greaterNumber < fourthNumber)
            {
                greaterNumber = fourthNumber;
            }
            if (greaterNumber < fifthNumber)
            {
                greaterNumber = fifthNumber;
            }
            Console.WriteLine("The greatest number is {0}.", greaterNumber);
        }
    }
}