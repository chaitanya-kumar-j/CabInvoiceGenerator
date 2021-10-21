using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTestCases
{
    public class Tests
    {
        private FareCalculator fareCalculator;
        const int MINIMUM_FARE = 5;
        [SetUp]
        public void Setup()
        {
            this.fareCalculator = new FareCalculator();
        }

        [Test]
        public void GivenDistanceAndTimeProper_WhenCalculateFare_ShouldReturnTotalFare()
        {
            double expectedFare = 31;
            double resultFare = fareCalculator.CalculateFare(3, 1);
            Assert.AreEqual(expectedFare,resultFare);
        }

        [Test]
        public void GivenDistanceAndTimeSuchThatFareLessThanMinimumFare_WhenCalculateFare_ShouldReturnMinimumFare()
        {
            int expectedFare = MINIMUM_FARE;
            double resultFare = fareCalculator.CalculateFare(0.3, 1);
            Assert.AreEqual(expectedFare, resultFare);
        }
    }
}