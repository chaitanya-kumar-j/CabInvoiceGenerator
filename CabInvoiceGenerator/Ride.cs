using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distanceTravelledInKm, timeOfTravelInMinutes;
        public Ride(double distanceTravelledInKm, double timeOfTravelInMinutes)
        {
            this.distanceTravelledInKm = distanceTravelledInKm;
            this.timeOfTravelInMinutes = timeOfTravelInMinutes;
        }
    }
}
