using System;

namespace PostalDeliveryService
{
    public abstract class DeliveryItem
    {
        public string TrackingNumber { get; set; }
        public double Weight { get; set; }

        protected DeliveryItem(string trackingNumber, double weight)
        {
            TrackingNumber = trackingNumber;
            Weight = weight;
        }

        public abstract double CalculateCost();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Tracking Number: {TrackingNumber}");
            Console.WriteLine($"Weight: {Weight} kg");
        }
    }
}
