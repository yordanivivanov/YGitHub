﻿using System;
 
    class ExchangeBits___ExtraTask
    {
        static void Main()
        {

            /*
             * * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
             */
          
            Console.WriteLine("Write the first number, then p->q->k");
            uint number;
            byte q, k, p;

            bool isNum = uint.TryParse(Console.ReadLine(), out number);
            bool isP = byte.TryParse(Console.ReadLine(), out p);
            bool isQ = byte.TryParse(Console.ReadLine(), out q);
            bool isK = byte.TryParse(Console.ReadLine(), out k);
            string str = Convert.ToString(number, 2).PadLeft(32, '0');

            Console.WriteLine("Before : {0}", str);
            p = (byte)(p - 1);
            q = (byte)(q - 1);

            if ((isNum && isP && isQ && isK) && (p < q && (k + q) <= 32))
            {
                while (k != 0)
                {
                    int mask = 1 << p, maskSecond = 1 << q;
                    uint maskBit = (uint)(number & mask);
                    uint maskBitS = (uint)(number & maskSecond);
                    if ((maskBit >> p) == (maskBitS >> q)) { goto here; }
                    if ((maskBit >> p) != (maskBitS >> q) && (maskBit >> p != 0))
                    {
                        int reverseMask = ~(1 << p);
                        number = (uint)(number | maskSecond);
                        number = (uint)(number & reverseMask);

                    }
                    else if ((maskBit >> p) != (maskBitS >> q) && (maskBitS >> q != 0))
                    {
                        int reverseMask = ~(1 << q);
                        number = (uint)(number | mask);
                        number = (uint)(number & reverseMask);
                    }
                here: ;
                    p++;
                    q++;
                    k--;
                }
                Console.Write("After :  ");
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            }
            else Console.WriteLine("Wrong Input");
        }
    }

