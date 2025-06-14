
namespace orders.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; }

        // constructors
        public OrderItem()
        {
        }
        public OrderItem(int quantity, decimal price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public decimal SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, Quantity: {Quantity}, Subtotal: R${SubTotal()}";
        }
    }
}