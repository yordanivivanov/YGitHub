using System;

class informationAboutASCII 
{
    static void Main()
    {
        Console.Title = "ASCII Table";

        for (int c = 0; c < 127; c++)
        {
            Console.WriteLine("Character: {0} = {1}", c, (char)c);
        }
    }
}

