using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TracksineWebScrapper.Entities;
using TracksineWebScrapper.Entities.Models;

namespace TracksineWebScrapper.DataAccess
{
    public class TracksineContext : DbContext
    {
        public DbSet<SpinHistory> SpinHistory { get; set; }
        public DbSet<SpinHistoryModel> SpinHistoryModel { get; set; }
        public DbSet<MainModel> MainModel { get; set; }
        public DbSet<SpinResultImage> SpinResultImage { get; set; }
        public DbSet<SlotResultImage> SlotResultImage { get; set; }

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
