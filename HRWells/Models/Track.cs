using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRWells.Models
{
    public class Track
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfLanes { get; set; }
        public int Distance { get; set; }

        // Navigation Properties
        public IEnumerable<Race> Races { get; set; }
    }
}