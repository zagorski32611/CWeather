using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace weatherapp
{
    public class WeatherContext : DbContext
    {
        public DbSet<WeatherData> Weather { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currently>()
                .HasKey(b => b.Currently_Id)
                .HasName("OldCurrently_Id");
            
            modelBuilder.Entity<Daily>()
                .HasKey(c => c.Daily_Id)
                .HasName("Daily_id");

            modelBuilder.Entity<Days>()
                .HasKey(d => d.Days_Id)
                .HasName("Days_Id");

            modelBuilder.Entity<Flags>()
                .HasKey(e => e.Flag_Id)
                .HasName("Falgs_Id");
            
            modelBuilder.Entity<Alerts>()
                .HasKey(f => f.Alert_Id)
                .HasName("Alerts_Id");
            
            modelBuilder.Entity<AlertData>()
                .HasKey(g => g.alerts_id1)
                .HasName("Alerts_Id1");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source=localhost;Database=weather_app.db;User Id=SA; Password=password1#;");
            // password1#
            // sa
        }

    }
}


// optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");