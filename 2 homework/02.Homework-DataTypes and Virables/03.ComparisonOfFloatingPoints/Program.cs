using System;

    class ComparisonOfFloatingPoints
    {
        static void Main()
        {
            Console.Write("Please enter 1st number:");
            string firstnum = Console.ReadLine(); //You have to use ,(comma) instead of .(dot) as separator
            float firstnumf = float.Parse(firstnum);
            Console.Write("Please enter 2nd number:");
            string secondnum = Console.ReadLine(); //You have to use ,(comma) instead of .(dot) as separator
            float secondnumf = float.Parse(secondnum);
            bool result = firstnumf == secondnumf;
            Console.WriteLine("The numbers are equal:{0}", result);
        }
    }
