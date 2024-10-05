using System.Globalization;

namespace ShopProject.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }

        public double Price { get; set; }

        public Product Product { get; set; }


        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Price * Quantity;
        }

        public override string ToString() => Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + "Total: "
                + subTotal().ToString("F2", CultureInfo.InvariantCulture)
                ;

    }
}
