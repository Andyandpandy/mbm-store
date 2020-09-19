namespace MbmStore.Models.Products
{
    public class Book : Product
    {
        public Book( string author, string title, decimal price , short published) : base(title, price)
        {
            Author = author;
            Published = published;
        }

        public string Author;
        public string Publisher;
        public short Published;
        public string ISBN;
    }
}