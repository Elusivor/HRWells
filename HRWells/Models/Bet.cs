namespace HRWells.Models
{
    public class Bet
    {
        public int ID { get; set; }
        public float Amount { get; set; }
        public string Name { get; set; }
        public Entry Entry { get; set; }
        public int EntryID { get; set; }
    }
}