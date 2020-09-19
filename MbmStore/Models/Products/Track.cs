using System;
using System.Web.Mvc.Routing.Constraints;

namespace MbmStore.Models.Products
{
    public class Track
    {
        public Track(string title, TimeSpan length)
        {
            Title = title;
            Length = length;
        }

        public string Title;
        public TimeSpan Length;
        public string Composer;
    }
}