namespace MbmStore.Models
{
    public class OrderItem
    {
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            TotalPrice = product.Price * quantity;
        }

        public int OrderItemId;
        public int ProductId;
        public Product Product;
        public int Quantity;
        public readonly decimal TotalPrice;
    }
}