using System;

class ObjectVariableHelloWold
{
    static void Main()
    {
        string strHello = "Hello";
        string strWorls = "World!";
        object objHelloWorld = (strHello + " " + strWorls);

        Console.WriteLine(objHelloWorld);

        string thirdVar = (string)objHelloWorld;
        Console.WriteLine(thirdVar);
     }
}
