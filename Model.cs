using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace weatherapp
{
    public class WeatherContext : DbContext
    {
        public DbSet<WeatherData> Weather { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source=localhost;Database=weather_app.db;User Id=SA; Password=password1#;");
            // password1#
            // sa
        }
    }
}


// optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");