using HRWells.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using HRWells.ViewModels;

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
            var llist = new Dictionary<DateTime, string>();
            var entries = _context.Entries.Include(h => h.Horse).Include(j => j.Jockey).Include(t => t.Race.Track).Where(e => e.RaceID == ID).ToList();
            var lolist = _context.Races.OrderBy(c => c.TOD).ToList();
            var race = _context.Races.Where(r => r.ID == ID).Include(t => t.Track).FirstOrDefault();
            //var track = _context.Tracks.Where(t => t.ID == race.Track.ID).FirstOrDefault();
            foreach (var item in lolist)
            {
                llist.Add(item.TOD, $"Race ({item.ID})");
            }
            //Create a viewmodel to send to the viewz
            RaceEntryVeiwModel TheEntriesForThisRace = new RaceEntryVeiwModel()
            {
                Race = race,
                Entries = entries,
                Llist = llist
            };

            //If Null
            if (TheEntriesForThisRace.Race == null /*|| track.Name == null*/)
            {
                return HttpNotFound();
                //return View("PageNotFound");
            }
            return View(TheEntriesForThisRace);
        }
        public ActionResult PageNotFound()
        {

            return View("PageNotFound");
        }
    }
}