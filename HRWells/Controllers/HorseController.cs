using HRWells.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace HRWells.Controllers
{
    public class HorseController : Controller
    {
        ApplicationDbContext _context;
        public HorseController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Horse
        public ActionResult Index()
        {
            var horses = _context.Horses.Include(h => h.Breed).ToList();
            return View(horses);
        }
        public ActionResult HorsesByAttrib(string attrib, string value)
        {
            IEnumerable<Horse> theList;
            float floatVal;
            int intVal;


            switch (attrib)
            {
                case "weight":
                    floatVal = float.Parse(value);
                    theList = _context.Horses
                       .Where(h => h.Weight == floatVal)
                       .Include(h => h.Breed)
                       .ToList();
                    break;

                case "age":
                    intVal = int.Parse(value);
                    theList = _context.Horses
                       .Where(h => h.Age == intVal)
                       .Include(h => h.Breed)
                       .ToList();

                    break;

                case "number":
                    intVal = int.Parse(value);
                    theList = _context.Horses
                       .Where(h => h.Number == intVal)
                       .Include(h => h.Breed)
                       .ToList();

                    break;

                case "owner":
                    theList = _context.Horses
                       .Where(h => h.Owner == (string)value)
                       .Include(h => h.Breed)
                       .ToList();

                    break;
                case "breed":
                    theList = _context.Horses
                        .Include(h => h.Breed)
                        .Where(h => h.Breed.Name == (string)value)
                        .ToList();
                    break;

                default:
                    return Content("Not found");
            }

            return View("Index", theList);

        }

        public ActionResult Single(int ID)
        {
            //Fetch the horse record from the database
            Horse MyHorse;

            MyHorse = _context.Horses.Find(ID);
            if (MyHorse == null)
            {
                return HttpNotFound();
            }
            return View(MyHorse);

        }
    }
}