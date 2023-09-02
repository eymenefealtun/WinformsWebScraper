using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TracksineWebScrapper.Entities;

namespace TracksineWebScrapper.DataAccess
{
    public class TracksineContext : DbContext
    {
        public DbSet<SpinHistory> SpinHistory { get; set; }

        public TracksineContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon1"));

        }


    }
}
