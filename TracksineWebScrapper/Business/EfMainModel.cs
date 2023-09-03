using Microsoft.EntityFrameworkCore;
using TracksineWebScrapper.DataAccess;
using TracksineWebScrapper.Entities;

namespace TracksineWebScrapper.Business
{
    internal class EfMainModel
    {

        public List<MainModel> GetDataGridData()
        {
            using (TracksineContext context = new TracksineContext())       
            {
                return context.Set<MainModel>().FromSqlRaw(@"
SELECT S.Id,S.OccuredAt, S.SlotResult,I.ImageCode 'SpinResult', S.Multiplier,S.TotalWinners, S.TotalPayout,  I.Id 'ImageId', I.ImageText FROM SpinHistory S
JOIN Images I ON I. Id = S.SpinResult ORDER BY s.Id DESC").ToList();
            }
        }


    }
}
