namespace MbmStore.Models.Products
{
    public class Movie : Product
    {
        public Movie(string title, decimal price) : base(title, price)
        {
        }

        public Movie(string title, decimal price, string director, string imageUrl) : base(title, price)
        {
            Director = director;
            ImageFileName = imageUrl;
            Released = 0;
        }

        public string Director;
        public short Released;
    }
}