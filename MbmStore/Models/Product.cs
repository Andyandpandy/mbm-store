namespace MbmStore.Models
{
    public class Product
    {
        public Product()
        {
            Title = "";
            Price = 0;
            ImageFileName = "";
        }

        public Product(string title, decimal price)
        {
            Title = title;
            Price = price;
            ImageFileName = "";
            
        }

        public int ProductId;
        public string Title;
        public decimal Price;
        public string ImageFileName;
    }
}