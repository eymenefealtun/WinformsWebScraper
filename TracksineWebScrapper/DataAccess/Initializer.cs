using Microsoft.Extensions.Configuration;

namespace TracksineWebScrapper.DataAccess
{
    public class Initializer
    {

        public static IConfigurationRoot Configuration;

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }
    }
}
