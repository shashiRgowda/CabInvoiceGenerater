using NUnit.Framework;

namespace CabInvoicegeneratorTest
{
    [TestClass]
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;

        public object RideType { get; private set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            NUnit.Framework.Assert.AreEqual(expected, fare);
        }


        [Test]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 5), new Ride(4.0, 8), new Ride(2.0, 4), new Ride(10.0, 8) };
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(5, 215);
            NUnit.Framework.Assert.AreEqual(expectedSummary.GetType(), summary.GetType());
        }

        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFareForPremium()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            double distance = 5.0;
            int time = 10;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 95;
            NUnit.Framework.Assert.AreEqual(expected, fare);
        }


        [Test]
        public void GivenMultipleRideShouldReturnInvoiceSummaryForPremium()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] rides = { new Ride(5.0, 10), new Ride(0.2, 5), new Ride(10.0, 20), new Ride(2.0, 4), new Ride(15.0, 30) };
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(5, 638);
            NUnit.Framework.Assert.AreEqual(expectedSummary.GetType(), summary.GetType());
        }


    }



}