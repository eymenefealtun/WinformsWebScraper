using System.Linq.Expressions;
using TracksineWebScrapper.DataAccess;
using TracksineWebScrapper.Entities;

namespace TracksineWebScrapper.Business
{
    public class EfSlotResultImage
    {

        public SlotResultImage GetById(Expression<Func<SlotResultImage, bool>> filter)
        {
            using (TracksineContext context = new TracksineContext())
            {
                return context.Set<SlotResultImage>().SingleOrDefault(filter);          
            }

           
        }
        public List<SlotResultImage> GetAll(Expression<Func<SlotResultImage, bool>> filter = null)
        {
            using (TracksineContext context = new TracksineContext())
            {
                return filter == null ? context.Set<SlotResultImage>().ToList() : context.Set<SlotResultImage>().Where(filter).ToList();
            }
        }
    }
}
