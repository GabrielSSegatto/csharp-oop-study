using System.Collections.Generic;
using orders.Entities.Enums;
using orders.Entities;

namespace orders.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        //constructors
        public Order()
        {
            Moment = DateTime.Now;
        }
        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }
        
        // methods
        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public decimal Total()
        {
            decimal total = 0.0m;
            foreach (OrderItem item in OrderItems)
            {
                total += item.SubTotal();
            }
            return total;
        }
    }
}