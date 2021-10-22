using System;
using System.Collections.Generic;

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
                    "1. Calcate Fare per ride, 2. Calculate Multiple rides aggregate fare");
                int ucNumber = Convert.ToInt32(Console.ReadLine());
                switch (ucNumber)
                {
                    case 1:
                        double distanceTravelledInKm = 0.3, timeOfTravelInMinutes = 1;
                        double fare = fareCalculator.CalculateFare(distanceTravelledInKm, timeOfTravelInMinutes);
                        Console.WriteLine($"Fare for ride of {distanceTravelledInKm} Km in {timeOfTravelInMinutes} minutes is: Rs.{fare}");
                        break;
                    case 2:
                        List<Ride> ridesList = new List<Ride>();
                        ridesList.Add(new Ride(4, 2));
                        ridesList.Add(new Ride(6, 4));
                        ridesList.Add(new Ride(8, 6));
                        ridesList.Add(new Ride(3, 2));
                        ridesList.Add(new Ride(7, 10));
                        double fareOfMultipleRides = fareCalculator.CalculateFareForMultipleRides(ridesList);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
