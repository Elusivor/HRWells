using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRWells.Models
{
    public class Horse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Number { get; set; }
        public string Owner { get; set; }
        public float Weight { get; set; }
        public BreedType Breed { get; set; }
        public int BreedTypeID { get; set; }

        //NAVIGATION PROPERTIES
        public IEnumerable<Entry> Entries { get; set; }
    }
}