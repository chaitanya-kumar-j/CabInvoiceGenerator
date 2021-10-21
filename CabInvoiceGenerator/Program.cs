using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                FareCalculator fareCalculator = new FareCalculator();
                Console.WriteLine("Select and enter UC number to run:\n" +
                    "1. Calcate Fare per ride");
                int ucNumber = Convert.ToInt32(Console.ReadLine());
                switch (ucNumber)
                {
                    case 1:
                        double distanceTravelledInKm = 0.3, timeOfTravelInMinutes = 1;
                        double fare = fareCalculator.CalculateFare(distanceTravelledInKm, timeOfTravelInMinutes);
                        Console.WriteLine($"Fare for ride of {distanceTravelledInKm} Km in {timeOfTravelInMinutes} minutes is: Rs.{fare}");
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
