using System.Linq.Expressions;
using TracksineWebScrapper.DataAccess;
using TracksineWebScrapper.Entities;

namespace TracksineWebScrapper.Business
{
    internal class EfSpinResultImage
    {
        public List<SpinResultImage> GetAll(Expression<Func<SpinResultImage, bool>> filter = null)
        {
            using (TracksineContext context = new TracksineContext())
            {
                return filter == null ? context.Set<SpinResultImage>().ToList() : context.Set<SpinResultImage>().Where(filter).ToList();
            }
        }
    }
}
