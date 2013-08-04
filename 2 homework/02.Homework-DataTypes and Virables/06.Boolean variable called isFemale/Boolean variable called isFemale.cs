using System;

class booleanVariableCalledIsFemale
{
    static void Main()
    {
        bool isFemale;
        Console.WriteLine("What is my gender: male/female?");
        string myGender = Console.ReadLine();

        if (myGender == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }

        Console.WriteLine("You are female = {0} ", isFemale);
        }
}

