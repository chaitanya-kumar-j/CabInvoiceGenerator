using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        public int noOfRides;
        public double totalFare, averageFare;
        public InvoiceSummary(int noOfRides, double totalFare)
        {
            this.noOfRides = noOfRides;
            this.totalFare = totalFare;
            this.averageFare = totalFare/noOfRides;
        }
    }
}
