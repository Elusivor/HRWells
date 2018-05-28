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
        public ActionResult Single(int ID)
        {
            Race MyRace;
            MyRace = _context.Races.Include(t => t.Track).SingleOrDefault(r => r.ID == ID);
            if (MyRace == null)
            {
                return HttpNotFound();
            }
            return View(MyRace);
        }
        public ActionResult Delete(int ID)
        {
            var race = _context.Races.Find(ID);
            if (race == null)
            {
                return HttpNotFound();
            }
            else
            {
                _context.Races.Remove(_context.Races.Find(ID));
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}