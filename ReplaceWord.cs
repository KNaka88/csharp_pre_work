using System;

class EncryptWords
{
    static void Main()
    {
        Console.WriteLine("Please type something here...");
        string userInput = Console.ReadLine();
        string myEncryptedResults = userInput.Replace("e", "friendlyhippopotamus");
        Console.WriteLine(myEncryptedResults);
    }
}