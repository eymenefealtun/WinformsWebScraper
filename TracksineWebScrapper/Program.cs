using Microsoft.Extensions.Configuration;

namespace TracksineWebScrapper
{
    internal static class Program
    {
        public static IConfiguration Configuration;
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
         .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }

    }
}