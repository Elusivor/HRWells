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
        // GET: Horse
        public ActionResult Index()
        {

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var horses = context.Horses.Include(h => h.Breed).ToList();
                return View(horses);
            }
        }
        public ActionResult HorsesByAttrib(string attrib, string value)
        {
            IEnumerable<Horse> theList;
            float floatVal;
            int intVal;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                switch (attrib)
                {
                    case "weight":
                        floatVal = float.Parse(value);
                        theList = context.Horses
                           .Where(h => h.Weight == floatVal)
                           .Include(h => h.Breed)
                           .ToList();
                        break;

                    case "age":
                        intVal = int.Parse(value);
                        theList = context.Horses
                           .Where(h => h.Age == intVal)
                           .Include(h => h.Breed)
                           .ToList();

                        break;

                    case "number":
                        intVal = int.Parse(value);
                        theList = context.Horses
                           .Where(h => h.Number == intVal)
                           .Include(h => h.Breed)
                           .ToList();

                        break;

                    case "owner":
                        theList = context.Horses
                           .Where(h => h.Owner == (string)value)
                           .Include(h => h.Breed)
                           .ToList();

                        break;


                    default:
                        return Content("Not found");
                }

                return View("Index", theList);

            }
        }
    }
}