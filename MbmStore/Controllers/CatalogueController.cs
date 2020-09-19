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
            
            /*
             Alternative tip solution.. I would prefer this..
             
            List<Book> books = new List<Book>();
            books = Repository.Products.OfType<Book>().ToList();
            ViewBag.Books = books;
            
            List<Movie> movies = new List<Movie>();
            movies = Repository.Products.OfType<Movie>().ToList();
            ViewBag.movies = movies;
            
            List<MusicCD> musicCDs = new List<MusicCD>();
            musicCDs = Repository.Products.OfType<MusicCD>().ToList();
            ViewBag.musicCDs = musicCDs;
            */
            ViewBag.Products = Repository.Products;
            return View();
        }
    }
}