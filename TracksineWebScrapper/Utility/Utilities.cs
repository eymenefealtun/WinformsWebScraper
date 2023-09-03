using TracksineWebScrapper.Entities;
using TracksineWebScrapper.Entities.Models;

namespace TracksineWebScrapper.Utility
{
    public class Utilities
    {
        static Form1 _mainForm { get; set; }
        static Random _random { get; set; }
        static Dictionary<string, Int16> _spinResultIcons;
        static Dictionary<string, Int16> _slotResultIcon;
        public Utilities(Form1 form)
        {
            _mainForm = form;
            _random = new Random();

            var spinResultIcons = new Dictionary<string, Int16>
            {
                { "1",8},
                { "2",7},
                { "5",6},
                { "10", 5},
                { "ct", 2},
                { "ch", 4},
                { "cf", 3},
                { "pa", 1}
            };
            var slotResultIcon = new Dictionary<string, Int16>
            {
                { "1",1},
                { "2",2},
                { "5",3},
                { "10", 4},
                { "ct", 7},
                { "ch", 5},
                { "cf", 6},
                { "pa", 8}
            };

            _spinResultIcons = spinResultIcons;
            _slotResultIcon = slotResultIcon;
        }

        internal static bool IsAddedBefore(SpinHistory spinHistory)
        {
            bool isAdded = false;

            for (int i = 0; i < _mainForm._last10Spin.Count(); i++)
            {
                if (_mainForm._last10Spin[i].OccuredAt == spinHistory.OccuredAt
                   && _mainForm._last10Spin[i].SlotResultImageId == spinHistory.SlotResultImageId
                   && _mainForm._last10Spin[i].SlotResultText == spinHistory.SlotResultText     
                   && _mainForm._last10Spin[i].SpinResultId == spinHistory.SpinResultId
                   && _mainForm._last10Spin[i].Multiplier == spinHistory.Multiplier
                   && _mainForm._last10Spin[i].TotalWinners == spinHistory.TotalWinners
                   && _mainForm._last10Spin[i].TotalPayout == spinHistory.TotalPayout)
                {

                    isAdded = true;
                    break;
                }
            }

            return isAdded;
        }

        internal static void SetLastTenValue()
        {
            _mainForm._last10Spin = null;
            _mainForm._last10Spin = _mainForm._efSpinHistory.GetLastTen().Select(x => new SpinHistoryModel
            {
                OccuredAt = x.OccuredAt,
                SlotResultImageId = x.SlotResultImageId,
                SlotResultText = x.SlotResultText,
                SpinResultId = x.SpinResultId,
                Multiplier = x.Multiplier,
                TotalWinners = x.TotalWinners,
                TotalPayout = x.TotalPayout
            }).ToArray();
        }
        internal static int GetRandomValue(int positive, int negative)
        {
            return Random1Over2() ? _random.Next(0, positive) : _random.Next(negative, 0);
        }

        private static bool Random1Over2()
        {
            return _random.Next(0, 10) < 4 ? false : true;
        }

        internal static Int16 GetSpinIconId(string input)
        {
            return _spinResultIcons.Where(x => x.Key == input).FirstOrDefault().Value;
        }



        internal static Int16 GetSlotResultImageId(string input)
        {
            return _slotResultIcon.Where(x => x.Key == input).FirstOrDefault().Value;
        }



    }
}
