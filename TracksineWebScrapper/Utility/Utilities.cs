using TracksineWebScrapper.Business;
using TracksineWebScrapper.Entities;
using TracksineWebScrapper.Entities.Models;

namespace TracksineWebScrapper.Utility
{
    public class Utilities
    {
        static Form1 _mainForm { get; set; }
        static Random _random { get; set; }

        static Dictionary<string, Int16> _iconMappings;

        static Dictionary<int, Byte[]> _slotIconBytesWithId;
        static Dictionary<int, Byte[]> _spinIconBytesWithId;

        EfSlotResultImage _efSlotResultImage;
        EfSpinResultImage _efSpinResultImage;
     

        public Utilities(Form1 form)
        {
            _mainForm = form;
            _random = new Random();

            _iconMappings = new Dictionary<string, Int16>
            {
                { "1",1},
                { "2",2},
                { "5",3},
                { "10", 4},
                { "ch", 5},
                { "cf", 6},
                { "ct", 7},
                { "pa", 8}
            };

            _efSlotResultImage = new EfSlotResultImage();
            _efSpinResultImage = new EfSpinResultImage();
            _slotIconBytesWithId = new Dictionary<int, Byte[]>();
            _spinIconBytesWithId = new Dictionary<int, Byte[]>();

            var slotResultImageTemp = _efSlotResultImage.GetAll();
            for (int i = 0; i < slotResultImageTemp.Count(); i++)
                _slotIconBytesWithId.Add(slotResultImageTemp[i].Id, slotResultImageTemp[i].ImageCode);

            var spinResultImageTemp = _efSpinResultImage.GetAll();
            for (int i = 0; i < spinResultImageTemp.Count(); i++)
                _spinIconBytesWithId.Add(spinResultImageTemp[i].Id, spinResultImageTemp[i].ImageCode);

        }

        internal static Int16 GetIdFromStringForSpin(string input)
        {
            return _iconMappings.Where(x => x.Key == input).FirstOrDefault().Value;
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

        internal static int GetRandomValue(int negativeSecond,int positiveSecond)
        {

            return Random1Over2() ? _random.Next(0, positiveSecond * 1000) : _random.Next(negativeSecond * 1000, 0);
        }

        private static bool Random1Over2()
        {
            return _random.Next(0, 10) < 4 ? false : true;
        }

        internal static Image ByteArrayToImage(byte[] byteAray)
        {
            using (MemoryStream ms = new MemoryStream(byteAray))
            {
                return Image.FromStream(ms);
            }
        }

        internal static Int16 GetIconIdAccordingToItsText(string input)
        {
            return _iconMappings.Where(x => x.Key == input).FirstOrDefault().Value;
        }

        internal static byte[] GetSpinResultImageByteFromIconId(int id)
        {
            return _spinIconBytesWithId.Where(x => x.Key == id).FirstOrDefault().Value;
        }

        internal static byte[] GetSlotResultImageByteFromIconId(int id)
        {
            return _slotIconBytesWithId.Where(x => x.Key == id).FirstOrDefault().Value;
        }


    }
}
