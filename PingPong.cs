using System;

public class PingPong
{
    public static void Main()
    {
        Console.WriteLine("Please type number");
        int number = int.Parse(Console.ReadLine());

        pingPong(number);
    }

    public static void pingPong(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            if ( (i % 3 == 0) && (i % 5 == 0) )
            {
                Console.WriteLine("ping-pong");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("ping");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("pong");
            } else {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
