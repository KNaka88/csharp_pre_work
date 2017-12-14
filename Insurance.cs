using System;

class Insurance
{
    static void Main()
    {
        Console.WriteLine("What is your gender? (male/female)");
        string gender = Console.ReadLine();

        Console.WriteLine("How old are you?");
        int age = int.Parse(Console.ReadLine());

        bool young = age < 26;
        bool male = gender == "male";

        if ( !(young && male) )
        {
            Console.WriteLine("Your insurace is going to be expensive, but it could be worse");
        }
        else
        {
            Console.WriteLine("Your insurance is going to be expensive");
        }
    }
}