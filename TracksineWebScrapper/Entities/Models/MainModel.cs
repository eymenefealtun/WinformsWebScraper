using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace TracksineWebScrapper.Entities.Models
{
    [Keyless]
    public class MainModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string OccuredAt { get; set; }
        public byte[] SlotResultImage { get; set; }
        public string SlotResultText { get; set; }
        public byte[] SpinResult { get; set; }
        public string Multiplier { get; set; }
        public int TotalWinners { get; set; }
        public string TotalPayout { get; set; }
        //public int ImageId { get; set; }
        //public string ImageText { get; set; }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}