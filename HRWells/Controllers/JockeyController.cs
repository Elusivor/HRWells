using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using HRWells.Models;

namespace HRWells.Controllers
{
    public class JockeyController : Controller
    {
        private ApplicationDbContext _context;
        public JockeyController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Jockey
        public ActionResult Index()
        {
            var jockey = _context.Jockeys.ToList();
            return View(jockey);
        }
    }
}