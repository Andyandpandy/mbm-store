using System;
using System.Collections.Generic;
using MbmStore.Models;
using MbmStore.Models.Products;

namespace MbmStore.Infrastructure
{
    static class Repository
    {
        
        public static List<Product> Products;
        public static List<Invoice> Invoices;
        
        static Repository()
        {
            // Create all objects here and add them to Products and Invoices

            Products = new List<Product>();
            Invoices = new List<Invoice>();
            
            Book b1 = new Book("Georg Martin", "With a Little Help from My Friends: The Movie Making of Sgt. Pepper", 1800M, 1995);
            b1.Publisher = "Little Brown & Co";
            b1.ISBN = "0316547832";
            b1.ImageFileName = "The Making of Sgt. Pepper.jpg";
            
            Book b2 = new Book("HCA", "Ugly Duckling", 1200M, 1800);
            b2.Publisher = "No one";
            b2.ISBN = "1234578";
            b2.ImageFileName = "bla";
            
            Book b3 = new Book("George", "GoT", 12000M, 2000);
            b3.Publisher = "No-one";
            b3.ISBN = "123457890";
            b3.ImageFileName = "blabla";
            
            Movie m1 = new Movie("Shawshank", 100, "that one guy", "bla");
            Movie m2 = new Movie("Harry Potter", 99);
            Movie m3 = new Movie("LOTR", 103);
            
            MusicCD mc1 = new MusicCD("snoopy", 10, "Snoopy d", 1);
            MusicCD mc2 = new MusicCD("Sweet", 11, "swwww", 1);
            MusicCD mc3 = new MusicCD("bla", 12, "blaaa", 1);
            
            Products.Add(b1);
            Products.Add(b2);
            Products.Add(b3);
            Products.Add(m1);
            Products.Add(m2);
            Products.Add(m3);
            
            Products.Add(mc1);
            Products.Add(mc2);
            Products.Add(mc3);

            Customer c1 = new Customer(1, "Tina", "Petterson", "langelinie 1", "1111", "Polis");
            Customer c2 = new Customer(2, "Tine", "Pettersone", "langelinie 2", "1111", "Polis");
            //Customer c3 = new Customer(3, "Tiner", "Pettersoner", "langelinie 3", "1111", "Polis");
            
            Invoice i1 = new Invoice(1, DateTime.Now, c1);
            Invoice i2 = new Invoice(2, DateTime.Now, c1);
            Invoice i3 = new Invoice(3, DateTime.Now, c2);
            
            OrderItem oi1 = new OrderItem(m1, 1);
            OrderItem oi2 = new OrderItem(m2, 2);
            OrderItem oi3 = new OrderItem(m3, 1);
            OrderItem oi4 = new OrderItem(b1, 1);
            OrderItem oi5 = new OrderItem(b2, 2);
            OrderItem oi6 = new OrderItem(b3, 1);
            OrderItem oi7 = new OrderItem(b3, 4);

            i1.AddOrderItem(oi1);
            i1.AddOrderItem(oi7);
            i1.AddOrderItem(oi3);
            i2.AddOrderItem(oi6);
            i2.AddOrderItem(oi2);
            i3.AddOrderItem(oi4);
            i3.AddOrderItem(oi5);
            i3.AddOrderItem(oi6);
            i3.AddOrderItem(oi1);
            
            Invoices.Add(i1);
            Invoices.Add(i2);
            Invoices.Add(i3);
        }
    }
}