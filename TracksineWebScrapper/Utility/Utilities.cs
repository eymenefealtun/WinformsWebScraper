using System;
using TracksineWebScrapper.Entities;

namespace TracksineWebScrapper.Utility
{
    public class Utilities
    {
        static Form1 _mainForm { get; set; }
        static Random _random { get; set; }

        public Utilities(Form1 form)
        {
            _mainForm = form;
            _random = new Random();
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


        internal static int GetRandomValue()
        {
            int positive = _random.Next(0, 20000); //20 second +
            int negative = _random.Next(-10000, 0); //10 second -

            return Random1Over2() ? positive : negative;
        }

        private static bool Random1Over2()
        {
            int value = _random.Next(0, 10);
            return value < 4 ? false : true;
        }


    }
}
