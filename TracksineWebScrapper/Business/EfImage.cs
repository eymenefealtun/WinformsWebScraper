using System.Linq.Expressions;
using TracksineWebScrapper.DataAccess;

namespace TracksineWebScrapper.Business
{
    internal class EfImage
    {
        public Entities.Image GetById(Expression<Func<Entities.Image, bool>> filter)
        {
            using (TracksineContext context = new TracksineContext())
            {       
                return context.Set<Entities.Image>().SingleOrDefault(filter);
            }
        }
    }
}
