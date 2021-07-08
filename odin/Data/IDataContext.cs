using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using odin.Models;

namespace odin.Data
{
    public interface IDataContext
    {
        DbSet<ActivityCard> ActivityCards { get; init; }
        DbSet<WeatherForecast> WeatherForecasts { get; init; }  //Test thing

        public int SaveChanges();


    }
}