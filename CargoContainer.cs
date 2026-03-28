using System.Collections.Generic;

namespace PostalDeliveryService
{
    public class CargoContainer<T> where T : DeliveryItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public double GetTotalCost()
        {
            double total = 0;

            foreach (T item in items)
            {
                total += item.CalculateCost();
            }

            return total;
        }
    }
}
