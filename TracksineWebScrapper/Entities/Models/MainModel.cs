using Microsoft.EntityFrameworkCore;

namespace TracksineWebScrapper.Entities.Models
{
    [Keyless]
    public class MainModel 
    {
        public int Id { get; set; }
        public string OccuredAt { get; set; }
        public byte[] SlotResultImage { get; set; }
        public string SlotResultText { get; set; }
        public byte[] SpinResultImage { get; set; }
        public string Multiplier { get; set; }
        public int TotalWinners { get; set; }
        public string TotalPayout { get; set; }


    }
}
