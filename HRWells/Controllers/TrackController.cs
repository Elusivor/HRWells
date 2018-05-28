using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using HRWells.Models;

namespace HRWells.Controllers
{
    public class TrackController : Controller
    {
        private ApplicationDbContext _context;
        public TrackController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Track
        public ActionResult Index()
        {
            var track = _context.Tracks.ToList();
            return View(track);
        }
        public ActionResult Single(int ID)
        {
            var Track = _context.Tracks.Find(ID);
            if(Track == null)
            {
                return View("PageNotFound");
            }
            return View(Track);
        }
        public ActionResult Delete(int ID)
        {
            var Track = _context.Tracks.Find(ID);
            if (Track == null)
            {
                return View("PageNotFound");
            }
            else
            {
                _context.Tracks.Remove(_context.Tracks.Find(ID));
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}