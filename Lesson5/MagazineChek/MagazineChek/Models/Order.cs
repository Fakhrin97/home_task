using System;
using System.Collections;

namespace MagazineChek.Models
{
    internal class Order
    {
        
        public ArrayList Orders { get; set; }
        public Order()
        {
            Orders = new ArrayList();
        }
        public void Add(Product product, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Orders.Add(product);
            }
            

        }
        public ArrayList Get()
        {
            DateTimeOffset now = DateTimeOffset.Now;
            Console.WriteLine(now);

            return Orders;

        }
        public int TotalPrice()
        {
            int total = 0;
            foreach (Product product in Orders)
            {
                total += product.Price;
            }
            return total;
        }


    }
}
