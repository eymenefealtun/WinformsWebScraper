using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using TracksineWebScrapper.DataAccess;
using TracksineWebScrapper.Entities.Models;

namespace TracksineWebScrapper.Business
{
    internal class EfMainModel
    {

        public List<MainModel> GetDataGridData()
        {
            using (TracksineContext context = new TracksineContext())
            {
                return context.Set<MainModel>().FromSqlRaw(@"
SELECT S.Id , S.OccuredAt, ISlot.ImageCode 'SlotResultImage', S.SlotResultText , ISpin.ImageCode 'SpinResult' , S.Multiplier, S.TotalWinners, S.TotalPayout   FROM SpinHistory S 
JOIN SpinResultImage ISpin ON Ispin.Id = S.SpinResultId
JOIN SlotResultImage ISlot ON ISlot.Id = S.SlotResultImageId
 ORDER BY s.Id DESC").ToList();
              
            }
        }


    }
}
