using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    class FareCalculator
    {
        const int MINIMUM_FARE = 5, COST_PER_KM = 10, Cost_PER_MINUTE = 1;
        public double CalculateFare(double distanceTravelledInKm, double timeOfTravelInMinutes)
        {
            double fare = (distanceTravelledInKm * COST_PER_KM) + (timeOfTravelInMinutes * Cost_PER_MINUTE);
            return Math.Max(fare, MINIMUM_FARE);
        }
    }
}
