using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TracksineWebScrapper.DataAccess;
using TracksineWebScrapper.Entities.Models;

namespace TracksineWebScrapper.Business
{
    public class EfSpinHistoryModel
    {
        public EfSpinHistoryModel()
        {

        }
        public async Task<List<SpinHistoryModel>> GetAllRawAsync()
        {
            using (TracksineContext context = new TracksineContext())
            {
                return await context.Set<SpinHistoryModel>().FromSqlRaw(@"SELECT 
                                                                          OccuredAt, 
                                                                          SlotResult, 
                                                                          SpinResult, 
                                                                          Multiplier, 
                                                                          TotalWinners, 
                                                                          TotalPayout 
                                                                          FROM SpinHistory").ToListAsync();
            }
        }
        public List<SpinHistoryModel> GetAllRaw()
        {
            using (TracksineContext context = new TracksineContext())
            {
                return context.Set<SpinHistoryModel>().FromSqlRaw(@"SELECT 
                                                                          OccuredAt, 
                                                                          SlotResult, 
                                                                          SpinResult, 
                                                                          Multiplier, 
                                                                          TotalWinners, 
                                                                          TotalPayout 
                                                                          FROM SpinHistory
                                                                          ORDER BY Id DESC").ToList();
            }
        }

    }
}
