using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRWells.ViewModels
{
    public class RaceEntryVeiwModel
    {
        public IEnumerable<Models.Entry> Entries { get; set; }
        public Models.Race Race { get; set; }
        public Dictionary<DateTime, string> Llist { get; set; }
    }
}