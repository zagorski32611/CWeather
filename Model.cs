using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace weatherapp
{
    public class WeatherContext : DbContext
    {
        public DbSet<WeatherData> Weather { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=weather_app.db");
        }
    }
}