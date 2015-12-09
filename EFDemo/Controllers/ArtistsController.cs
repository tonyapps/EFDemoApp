using EFDemo.Models;
using EFDemo.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDemo.Controllers
{
    public class ArtistsController : Controller
    {
        //MusicStoreDbContext context = new MusicStoreDbContext();
        //

        ArtistRepository repository = new ArtistRepository(); 
        
        public ActionResult Details(int id)
        {
            Artist artist = repository.Get(id);

            if (artist == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(artist);
            }
        }
        
        
        // GET: /Artists/
        public ActionResult Index()
        {
            //return View(repository.GetAll());
            return View(repository.GetSoloArtists());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            if (!ModelState.IsValid) return View(artist);

            repository.Add(artist);
            repository.SaveChanges();

            return RedirectToAction("Index");
        }
	}
}