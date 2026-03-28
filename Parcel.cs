using System;

namespace PostalDeliveryService
{
    public class Parcel : DeliveryItem
    {
        public string Dimensions { get; set; }

        public Parcel(string trackingNumber, double weight, string dimensions)
            : base(trackingNumber, weight)
        {
            Dimensions = dimensions;
        }

        public override double CalculateCost()
        {
            return 50 + (Weight * 25);
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Dimensions: {Dimensions}");
        }
    }
}
