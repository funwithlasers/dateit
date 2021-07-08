using System;

namespace odin.Models
{
    public class WeatherForecast : BaseEntity
    {
        public int WeatherForecastId { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);   //This line affects FetchData.vue

        public string Summary { get; set; }
    }
}
