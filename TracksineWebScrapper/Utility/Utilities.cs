using TracksineWebScrapper.Entities;

namespace TracksineWebScrapper.Utility
{
    public class Utilities
    {
        static Form1 _mainForm { get; set; }
        static Random _random { get; set; }
        static Dictionary<string, int> _spinResultIcons;
        public Utilities(Form1 form)
        {
            _mainForm = form;
            _random = new Random();

            var spinResultIcons = new Dictionary<string, int>
            {
                { "1",9},
                { "2",10},
                { "5",11},
                { "10", 12},
                { "ct", 13},
                { "ch", 14},
                { "cf", 15},
                { "pa", 16}
            };

            _spinResultIcons = spinResultIcons;
        }

        internal static bool IsAddedBefore(SpinHistory spinHistory)
        {
            bool isAdded = false;

            for (int i = 0; i < _mainForm._last10Spin.Count(); i++)
            {
                if (_mainForm._last10Spin[i].OccuredAt == spinHistory.OccuredAt
                   && _mainForm._last10Spin[i].SlotResult == spinHistory.SlotResult
                   && _mainForm._last10Spin[i].SpinResult == spinHistory.SpinResult
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
                SlotResult = x.SlotResult,
                SpinResult = x.SpinResult,
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

        internal static int GetSpinIconId(string input)
        {
            return _spinResultIcons.Where(x => x.Key == input).FirstOrDefault().Value;
        }






    }
}
