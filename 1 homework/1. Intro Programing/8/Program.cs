using System;

class MyAge
{
    static void Main()
    {
        System.Console.WriteLine("How old are you?");
        int age = int.Parse(System.Console.ReadLine());
        int result = age + 10;
        System.Console.WriteLine("Ten years from now you will be " + result + " years old.");
    }
}