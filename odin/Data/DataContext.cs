using Microsoft.EntityFrameworkCore;
using odin.Models;
using System;
using Serilog;

namespace odin.Data
{
    // This is the global data context. This should be used for CRUD operation interation with the DB. 
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ActivityCard> ActivityCards { get; init; }
        public DbSet<WeatherForecast> WeatherForecasts { get; init; }

    }
}