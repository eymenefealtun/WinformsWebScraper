using Microsoft.Extensions.Configuration;
using System.Configuration;
using TracksineWebScrapper.DataAccess;

namespace TracksineWebScrapper
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
         .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Initializer.Configuration = builder.Build();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }

    }
}