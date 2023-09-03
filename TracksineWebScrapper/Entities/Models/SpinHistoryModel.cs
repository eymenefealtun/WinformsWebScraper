using Microsoft.EntityFrameworkCore;

namespace TracksineWebScrapper.Entities.Models
{
    [Keyless]
    public class SpinHistoryModel
    {
        public string OccuredAt { get; set; }

        public Int16 SlotResultImageId { get; set; }
        public string SlotResultText { get; set; }

        public Int16 SpinResultId { get; set; }
        public string Multiplier { get; set; }
        public int TotalWinners { get; set; }
        public string TotalPayout { get; set; }


    }
}
