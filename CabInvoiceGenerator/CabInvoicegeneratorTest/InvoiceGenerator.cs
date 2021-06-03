using System;

namespace CabInvoicegeneratorTest
{
    internal class InvoiceGenerator
    {
        private object nORMAL;

        public InvoiceGenerator(object nORMAL)
        {
            this.nORMAL = nORMAL;
        }

        internal InvoiceSummary CalculateFare(double distance, Ride[] rides)
        {
            throw new NotImplementedException();
        }

        internal InvoiceSummary CalculateFare(double distance, Ride[] rides)
        {
            throw new NotImplementedException();
        }

        internal InvoiceSummary CalculateFare(Ride[] rides)
        {
            throw new NotImplementedException();
        }

        internal double CalculateFare(double distance, int time)
        {
            throw new NotImplementedException();
        }
    }
}