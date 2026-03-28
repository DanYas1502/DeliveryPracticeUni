using System;

namespace PostalDeliveryService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Letter letter1 = new Letter("LTR001", 0.3);
            Letter letter2 = new Letter("LTR002", 0.5);

            Parcel parcel1 = new Parcel("PRC001", 2.0, "30x20x15");
            Parcel parcel2 = new Parcel("PRC002", 3.5, "50x40x35");

            DeliveryItem item1 = letter1;
            DeliveryItem item2 = parcel1;

            Console.WriteLine("=== Letter Info ===");
            item1.PrintInfo();
            Console.WriteLine($"Cost: {item1.CalculateCost()} грн");

            Console.WriteLine();

            Console.WriteLine("=== Parcel Info ===");
            item2.PrintInfo();
            Console.WriteLine($"Cost: {item2.CalculateCost()} грн");

            Console.WriteLine();

            CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
            myCargo.AddItem(letter1);
            myCargo.AddItem(letter2);
            myCargo.AddItem(parcel1);
            myCargo.AddItem(parcel2);

            Console.WriteLine($"Total delivery cost: {myCargo.GetTotalCost()} грн");
        }
    }
}
