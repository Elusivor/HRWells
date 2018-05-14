using System.Collections.Generic;

namespace HRWells.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public int LaneNr { get; set; }
        public Horse Horse { get; set; }
        public int HorseID { get; set; }
        public Jockey Jockey { get; set; }
        public int JockeyID { get; set; }
        public Race Race { get; set; }
        public int RaceID { get; set; }
        //NAVIGATION PROPERTIES
        public IEnumerable<Bet> Bets { get; set; }
    }
}