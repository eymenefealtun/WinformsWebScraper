using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TracksineWebScrapper.DataAccess;
using TracksineWebScrapper.Entities;

namespace TracksineWebScrapper.Business
{
    public class EfSpinHistory
    {
        public EfSpinHistory()
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
        public void AddRange(List<SpinHistory> spinHistories)
        {
            using (TracksineContext context = new TracksineContext())
            {
                foreach (var item in spinHistories)
                    context.Set<SpinHistory>().Add(item);
                context.SaveChanges();
            }
        }
        public async Task<List<SpinHistory>> GetAllAsync(Expression<Func<SpinHistory, bool>> filter = null)
        {
            using (TracksineContext context = new TracksineContext())
            {
                return filter == null ? await context.Set<SpinHistory>().ToListAsync() : await context.Set<SpinHistory>().Where(filter).ToListAsync();
            }
        }
        public List<SpinHistory> GetAll(Expression<Func<SpinHistory, bool>> filter = null)
        {
            using (TracksineContext context = new TracksineContext())
            {
                return filter == null ? context.Set<SpinHistory>().ToList() : context.Set<SpinHistory>().Where(filter).ToList();
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
