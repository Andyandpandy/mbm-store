using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models.Products;

namespace MbmStore.Controllers
{
    public class CatalogueController: Controller
    {
        public ActionResult Index()
        {
            // Alternative solution based on tip

            
            
            List<Book> books = new List<Book>();
            books = Repository.Products.OfType<Book>().ToList();
            ViewBag.Books = books;
            
            List<Movie> movies = new List<Movie>();
            movies = Repository.Products.OfType<Movie>().ToList();
            ViewBag.movies = movies;
            
            List<MusicCD> musicCDs = new List<MusicCD>();
            musicCDs = Repository.Products.OfType<MusicCD>().ToList();
            ViewBag.musicCDs = musicCDs;
            
            System.Diagnostics.Debug.WriteLine(Repository.Products);
            System.Diagnostics.Debug.WriteLine(Repository.Invoices);

            System.Diagnostics.Debug.WriteLine(books.Count);
            System.Diagnostics.Debug.WriteLine(movies.Count);
            System.Diagnostics.Debug.WriteLine(musicCDs.Count);
            ViewBag.Products = Repository.Products;
            return View();
        }
    }
}