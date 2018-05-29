using HRWells.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace HRWells.Controllers
{
    public class RaceController : Controller
    {
        private ApplicationDbContext _context;
        public RaceController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Race
        public ActionResult Index()
        {

            var Race = _context.Races.Include(r => r.Track);
            return View(Race);
        }
        //public ActionResult Single(int ID)
        //{
        //    Race MyRace;
        //    MyRace = _context.Races.Include(t => t.Track).SingleOrDefault(r => r.ID == ID);
        //    if (MyRace == null)
        //    {
        //        return View("PageNotFound");
        //    }
        //    return View(MyRace);
        //}
        public ActionResult Delete(int ID)
        {
            var race = _context.Races.Find(ID);
            if (race == null)
            {
                return View("PageNotFound");
            }
            else
            {
                _context.Races.Remove(_context.Races.Find(ID));
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        public ActionResult Single(int ID)
        {
            //Create a viewmodel to send to the view
            Entry TheEntriesForThisRace = new Entry()
            {
                Race = _context.Races.Find(ID),
                Entries = _context.Entries.Include(h => h.Horse).Include(j => j.Jockey).Include(t => t.Race.Track).Where(e => e.RaceID == ID).ToList()
            };

            //If Null
            if (TheEntriesForThisRace.Race == null)
            {
                return HttpNotFound();
                //return View("PageNotFound");
            }
            return View(TheEntriesForThisRace);
        }
    }
}