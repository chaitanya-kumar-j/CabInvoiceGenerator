using CabInvoiceGenerator;
using NUnit.Framework;
using System.Collections.Generic;

namespace CabInvoiceGeneratorTestCases
{
    public class Tests
    {
        private InvoiceGenerator invoiceGenerator;
        const int MINIMUM_FARE = 5;
        [SetUp]
        public void Setup()
        {
            this.invoiceGenerator = new InvoiceGenerator();
        }

        [Test]
        public void GivenDistanceAndTimeProper_WhenCalculateFare_ShouldReturnTotalFare()
        {
            double expectedFare = 31;
            double resultFare = invoiceGenerator.CalculateFare(3, 1);
            Assert.AreEqual(expectedFare,resultFare);
        }

        [Test]
        public void GivenDistanceAndTimeSuchThatFareLessThanMinimumFare_WhenCalculateFare_ShouldReturnMinimumFare()
        {
            int expectedFare = MINIMUM_FARE;
            double resultFare = invoiceGenerator.CalculateFare(0.3, 1);
            Assert.AreEqual(expectedFare, resultFare);
        }

        [Test]
        public void GivenListOfRides_WhenCalculateFareForMultipleRides_ShouldReturnAggregateFare()
        {
            List<Ride> ridesList = new List<Ride>();
            ridesList.Add(new Ride(4, 2));
            ridesList.Add(new Ride(6, 4));
            ridesList.Add(new Ride(8, 6));
            ridesList.Add(new Ride(3, 2));
            ridesList.Add(new Ride(7, 10));
            double expectedFare = 304;
            double resultFare = invoiceGenerator.CalculateFareForMultipleRides(ridesList).totalFare;
            Assert.AreEqual(expectedFare, resultFare);
        }

        [Test]
        public void GivenListOfRides_WhenCalculateFareForMultipleRides_ShouldReturnInvoiceSummaryObject()
        {
            List<Ride> ridesList = new List<Ride>();
            ridesList.Add(new Ride(4, 2));
            ridesList.Add(new Ride(6, 4));
            ridesList.Add(new Ride(8, 6));
            ridesList.Add(new Ride(3, 2));
            ridesList.Add(new Ride(7, 10));
            // InvoiceSummary expectedObj = new InvoiceSummary(5,304);
            InvoiceSummary resultObj = invoiceGenerator.CalculateFareForMultipleRides(ridesList);
            Assert.AreEqual( (double) 304 / 5, resultObj.averageFare);
            Assert.AreEqual(304, resultObj.totalFare);
            Assert.AreEqual(5, resultObj.noOfRides);
        }
    }
}