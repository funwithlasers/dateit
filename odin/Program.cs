using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace odin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Initialize Logger
            //Read Configuration from appSettings.json
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            //Create Logger
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();

            try
            {
                Log.Information("Application Starting Up");
                CreateHostBuilder(args).Build().Run();

            }
            catch (Exception e)
            {
                Log.Fatal(e, "Application Failed to Initialize");
            }
            finally
            {
                Log.Debug("Closing and Flushing application");
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
            .UseSerilog()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
        }
    }
}
