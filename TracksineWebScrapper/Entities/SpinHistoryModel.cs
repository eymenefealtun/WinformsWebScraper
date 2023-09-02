using Microsoft.EntityFrameworkCore;

namespace TracksineWebScrapper.Entities
{
    [Keyless]
    public class SpinHistoryModel
    {
        public string OccuredAt { get; set; }
        public string SlotResult { get; set; }
        public string SpinResult { get; set; }
        public string Multiplier { get; set; }
        [Precision(18, 0)]
        public decimal TotalWinners { get; set; }
        public string TotalPayout { get; set; }
    }
}
