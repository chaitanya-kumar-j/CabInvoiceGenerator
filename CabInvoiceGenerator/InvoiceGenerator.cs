using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        const int MINIMUM_FARE = 5, COST_PER_KM = 10, Cost_PER_MINUTE = 1;
        double distanceTravelledInKm, timeOfTravelInMinutes, fare, totalFare = 0;
        public double CalculateFare(double distanceTravelledInKm, double timeOfTravelInMinutes)
        {
            double fare = (distanceTravelledInKm * COST_PER_KM) + (timeOfTravelInMinutes * Cost_PER_MINUTE);
            return Math.Max(fare, MINIMUM_FARE);
        }
        public InvoiceSummary CalculateFareForMultipleRides(List<Ride> ridesList)
        {
            foreach(Ride ride in ridesList)
            {
                totalFare += this.CalculateFare(ride.distanceTravelledInKm, ride.timeOfTravelInMinutes);
            }
            // Console.WriteLine($"Total fare of all rides is: {totalFare}");
            return new InvoiceSummary(ridesList.Count, totalFare);
            //bool isAnotherRide = true;
            //while (isAnotherRide)
            //{
            //    Console.WriteLine("Want to enter ride details? Enter 1. To add details, 2. To stop adding and get invoice");
            //    int userOption = Convert.ToInt32(Console.ReadLine());
            //    switch (userOption)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter the Distance travelled in Km: ");
            //            distanceTravelledInKm = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Enter the time of travel: ");
            //            timeOfTravelInMinutes = Convert.ToDouble(Console.ReadLine());
            //            fare = (distanceTravelledInKm * COST_PER_KM) + (timeOfTravelInMinutes * Cost_PER_MINUTE);
            //            totalFare += Math.Max(fare, MINIMUM_FARE);
            //            break;
            //        default:
            //            isAnotherRide = !isAnotherRide;
            //            break;
            //    }
            //}
            //Console.WriteLine($"Total fare of all rides is: {totalFare}");
            //return totalFare;
        }
    }
}
