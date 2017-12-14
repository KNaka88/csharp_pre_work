using System;

class CalculateShippingCost
{
    static void Main()
    {
        Console.WriteLine("Please Type Package Weight");
        string packageWeight = Console.ReadLine();
        Console.WriteLine("Please Type Distance to Travel");
        string distanceToTravel = Console.ReadLine();
        Console.WriteLine("Please type price modifier");
        string priceModifier = Console.ReadLine();

        Calculate(int.Parse(packageWeight), int.Parse(distanceToTravel), int.Parse(priceModifier));
    }

    static void Calculate(int packageWeight, int distanceToTravel, int priceModifier)
    {
        int result = (packageWeight / 10) + (distanceToTravel / 5) * priceModifier;
        Console.WriteLine("Result: $" + result.ToString() + ".");

    }


}