using System;

namespace PostalDeliveryService
{
    public class Letter : DeliveryItem
    {
        public Letter(string trackingNumber, double weight)
            : base(trackingNumber, weight)
        {
        }

        public override double CalculateCost()
        {
            return 15 + (Weight * 10);
        }
    }
}
