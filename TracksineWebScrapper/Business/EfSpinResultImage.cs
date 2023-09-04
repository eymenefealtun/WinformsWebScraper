using System.Linq.Expressions;
using TracksineWebScrapper.DataAccess;
using TracksineWebScrapper.Entities;

namespace TracksineWebScrapper.Business
{
    internal class EfSpinResultImage
    {
        public SpinResultImage GetById(Expression<Func<SpinResultImage, bool>> filter)
        {
            using (TracksineContext context = new TracksineContext())
            {       
                return context.Set<SpinResultImage>().SingleOrDefault(filter);
            }
        }
        public List<SpinResultImage> GetAll(Expression<Func<SpinResultImage, bool>> filter = null)
        {
            using (TracksineContext context = new TracksineContext())
            {
                return filter == null ? context.Set<SpinResultImage>().ToList() : context.Set<SpinResultImage>().Where(filter).ToList();
            }
        }
    }
}
