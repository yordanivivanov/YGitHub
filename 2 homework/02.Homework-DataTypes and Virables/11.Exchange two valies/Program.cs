using System;

class Program
{
    static void Main()
    {
        int varA = 5;
        int varB = 10;

        int varC = varB - varA;
        varA = varB;
        varB = varC;
      
        Console.WriteLine("varA={0}, varB = {1}", varA, varB);
    }
}
