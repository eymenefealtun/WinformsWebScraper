using Microsoft.EntityFrameworkCore;

namespace TracksineWebScrapper.Entities
{
    public class SpinHistory
    {
        public int Id { get; set; }
        public string OccuredAt { get; set; }

        public Int16 SlotResultImageId { get; set; }
        public string SlotResultText { get; set; }

        public Int16 SpinResultId { get; set; }
        public string Multiplier { get; set; }
        public int TotalWinners { get; set; }
        public string TotalPayout { get; set; }

    }
}
