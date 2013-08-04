using System;

    class exchangeBits
    {
        static void Main()
        {
            /*
             * Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
             */

            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int position1 = 3;
            int position2 = 24;

            int mask1 = 7 << position1; //111 moved to position 3,4,5
            int mask2 = 7 << position2; //111 moved to position 24,25,26

            int getNumber1 = number & mask1; //getting the numbers from 3,4,5
            int newget = getNumber1 >> position1;

            Console.WriteLine(newget);

            int getNumber2 = number & mask2; // getting the numbers from 24,25,26
            int change = (number & ~mask1) & ~mask2; //replacing possitions 3,4,5,24,25,26 with 0

            int mask3 = (getNumber1 >> position1) << position2; //moving the numbers to the correct position
            int mask4 = (getNumber2 >> position2) << position1;
            int result = (change | mask3) | mask4;   //placing the new bits into the number

            Console.WriteLine(result);
        }
    }
