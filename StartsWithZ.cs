using System;

class StartsWithZ
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        if (userName.ToUpper().StartsWith("Z"))
        {
            Console.WriteLine("Your name starts with a Z!");
        }
        else
        {
            Console.WriteLine("Your name doesn't start with a Z");
        }
    }
}