using System;

class FindTheThirdBit
{
    static void Main()
    {
        /*
         * Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
         */
        Console.WriteLine("Please enter a nuber: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 2;
        int result = number & mask;

        int bit = result >> 2;
        Console.WriteLine(bit);        //Here we find the 3th bit
        bool boolResult = (bit == 1);  //Here I write a bool exprecion, because the task says that we need to write a bool expresion
                                      
        if (boolResult == true)
        {
            Console.WriteLine("The bit 3 (counting from 0) of a given integer is 1: {0}. ", true);
        }
        else
        {
            Console.WriteLine("The bit 3 (counting from 0) of a given integer is 1: {0}. ", false);
        }
    }
}
