using System;

    class CheckTheThirdDigit
    {
        static void Main()
        {
            /*
             * Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.
             */
            int number = int.Parse(Console.ReadLine());
            int result = number / 100;

            if (result % 10 == 7)
            {
                Console.WriteLine("The third digit is 7.");
            }
            else
            {
                Console.WriteLine("The third digit is Not equal to 7.");
            }
        }
    }

