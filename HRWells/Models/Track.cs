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
        public uint NumberOfLanes { get; set; }
        public uint Distance { get; set; }
    }
}