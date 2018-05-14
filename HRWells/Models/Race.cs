using System;
using System.Collections.Generic;

namespace HRWells.Models
{
    public class Race
    {
        public int ID { get; set; }
        public DateTime TOD { get; set; }
        public Track Track { get; set; }
        public int TrackID { get; set; }

        //NAVIGATION PROPERTIES
        public IEnumerable<Entry> Entries { get; set; }
    }
}