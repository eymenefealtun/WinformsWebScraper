using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TracksineWebScrapper.DataAccess;
using TracksineWebScrapper.Entities;

namespace TracksineWebScrapper.Business
{
    public class EfTracksine
    {
        public EfTracksine()
        {
                
        }
        public async Task AddAsync(SpinHistory spinHistory)
        {
            using (TracksineContext context = new TracksineContext())
            {
                context.Set<SpinHistory>().Add(spinHistory);
                await context.SaveChangesAsync();
            }
        }

        public async Task AddRangeAsync(List<SpinHistory> spinHistories)
        {
            using (TracksineContext context = new TracksineContext())
            {
                foreach (var item in spinHistories)
                    context.Set<SpinHistory>().Add(item);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<SpinHistory>> GetAllAsync(Expression<Func<SpinHistory, bool>> filter = null)
        {
            using (TracksineContext context = new TracksineContext())
            {
                return filter == null ? await context.Set<SpinHistory>().ToListAsync() : await context.Set<SpinHistory>().Where(filter).ToListAsync();
            }
        }

        public async Task<SpinHistory> GetAsync(Expression<Func<SpinHistory, bool>> filter)
        {
            using (TracksineContext context = new TracksineContext())
            {
                return await context.Set<SpinHistory>().SingleOrDefaultAsync(filter);
            }
        }

    }
}
