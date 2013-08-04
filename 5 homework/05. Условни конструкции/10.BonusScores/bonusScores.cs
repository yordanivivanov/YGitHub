using System;
 
    class bonusScores
    {
        static void Main()
        {
            // Write a program that applies bonus scores to given scores in the range [1..9]. 
            //The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; 
            //if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
            //If it is zero or if the value is not a digit, the program must report an error.
            //Use a switch statement and at the end print the calculated new value in the console.

            Console.WriteLine("Enter a digit 1-9: ");

            string choice = Console.ReadLine();

            if ((choice == "1") || (choice == "2") || (choice == "3") || (choice == "4") || (choice == "5") || (choice == "6")
                 || (choice == "7") || (choice == "8") || (choice == "9"))
            {

                int numb = Convert.ToInt32(choice);

                switch (numb)
                {

                    case 1: Console.WriteLine(1 * 10); break;
                    case 2: Console.WriteLine(2 * 10); break;
                    case 3: Console.WriteLine(3 * 10); break;
                    case 4: Console.WriteLine(4 * 100); break;
                    case 5: Console.WriteLine(5 * 100); break;
                    case 6: Console.WriteLine(6 * 100); break;
                    case 7: Console.WriteLine(7 * 1000); break;
                    case 8: Console.WriteLine(8 * 1000); break;
                    case 9: Console.WriteLine(9 * 1000); break;
                    default: Console.WriteLine("Error");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }

