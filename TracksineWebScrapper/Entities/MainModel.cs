using Microsoft.EntityFrameworkCore;

namespace TracksineWebScrapper.Entities
{
    [Keyless]
    public class MainModel
    {
        public int Id { get; set; }     
        public string OccuredAt { get; set; }
        public string SlotResult { get; set; }
        public byte[] SpinResult { get; set; }
        public string Multiplier { get; set; }
        public int TotalWinners { get; set; }
        public string TotalPayout { get; set; }
        public int ImageId { get; set; }        
        public string ImageText { get; set; }
    }
}
