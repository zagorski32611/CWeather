﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using weatherapp;

namespace weatherapp.Migrations
{
    [DbContext(typeof(WeatherContext))]
    partial class WeatherContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("weatherapp.Alerts", b =>
                {
                    b.Property<string>("Alerts_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alerts_Id1");

                    b.Property<string>("WeatherDataCall_Id");

                    b.Property<string>("alert_time");

                    b.Property<string>("alert_title");

                    b.Property<string>("severity");

                    b.HasKey("Alerts_Id");

                    b.HasIndex("Alerts_Id1");

                    b.HasIndex("WeatherDataCall_Id");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("weatherapp.Currently", b =>
                {
                    b.Property<string>("Currently_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("apparentTemperature");

                    b.Property<double>("cloudCover");

                    b.Property<double>("dewPoint");

                    b.Property<double>("humidity");

                    b.Property<string>("icon");

                    b.Property<double>("nearestStormBearing");

                    b.Property<double>("nearestStormDistance");

                    b.Property<double>("ozone");

                    b.Property<double>("precipIntensity");

                    b.Property<double>("precipProbability");

                    b.Property<double>("pressure");

                    b.Property<string>("summary");

                    b.Property<double>("temperature");

                    b.Property<string>("time");

                    b.Property<double>("uvIndex");

                    b.Property<double>("visibility");

                    b.Property<double>("windBearing");

                    b.Property<double>("windGust");

                    b.Property<double>("windSpeed");

                    b.HasKey("Currently_Id");

                    b.ToTable("Currently");
                });

            modelBuilder.Entity("weatherapp.Daily", b =>
                {
                    b.Property<string>("Daily_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("icon");

                    b.Property<string>("summary");

                    b.HasKey("Daily_Id");

                    b.ToTable("Daily");
                });

            modelBuilder.Entity("weatherapp.Days", b =>
                {
                    b.Property<string>("Days_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Daily_Id");

                    b.Property<double>("apparentTemperatureHigh");

                    b.Property<string>("apparentTemperatureHighTime");

                    b.Property<double>("apparentTemperatureLow");

                    b.Property<string>("apparentTemperatureLowTime");

                    b.Property<double>("apparentTemperatureMax");

                    b.Property<string>("apparentTemperatureMaxTime");

                    b.Property<double>("apparentTemperatureMin");

                    b.Property<string>("apparentTemperatureMinTime");

                    b.Property<double>("cloudCover");

                    b.Property<double>("dewPoint");

                    b.Property<double>("humidity");

                    b.Property<string>("icon");

                    b.Property<double>("moonPhase");

                    b.Property<double>("ozone");

                    b.Property<double>("precipIntensity");

                    b.Property<double>("precipIntensityMax");

                    b.Property<string>("precipIntensityMaxTime");

                    b.Property<double>("precipProbability");

                    b.Property<string>("precipType");

                    b.Property<double>("pressure");

                    b.Property<string>("summary");

                    b.Property<string>("sunriseTime");

                    b.Property<string>("sunsetTime");

                    b.Property<double>("temperatureHigh");

                    b.Property<string>("temperatureHighTime");

                    b.Property<double>("temperatureLow");

                    b.Property<string>("temperatureLowTime");

                    b.Property<double>("temperatureMax");

                    b.Property<string>("temperatureMaxTime");

                    b.Property<double>("temperatureMin");

                    b.Property<string>("temperatureMinTime");

                    b.Property<string>("time");

                    b.Property<int>("uvIndex");

                    b.Property<string>("uvIndexTime");

                    b.Property<double>("visibility");

                    b.Property<int>("windBearing");

                    b.Property<double>("windGust");

                    b.Property<string>("windGustTime");

                    b.Property<double>("windSpeed");

                    b.HasKey("Days_Id");

                    b.HasIndex("Daily_Id");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("weatherapp.Flags", b =>
                {
                    b.Property<string>("Flag_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FlagsFlag_Id");

                    b.Property<string>("units");

                    b.HasKey("Flag_Id");

                    b.HasIndex("FlagsFlag_Id");

                    b.ToTable("Flags");
                });

            modelBuilder.Entity("weatherapp.WeatherData", b =>
                {
                    b.Property<string>("Call_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Currently_Id");

                    b.Property<string>("Daily_Id");

                    b.Property<string>("flagsFlag_Id");

                    b.Property<double>("latitude");

                    b.Property<double>("longitude");

                    b.Property<int?>("offset");

                    b.Property<string>("timezone");

                    b.HasKey("Call_Id");

                    b.HasIndex("Currently_Id");

                    b.HasIndex("Daily_Id");

                    b.HasIndex("flagsFlag_Id");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("weatherapp.Alerts", b =>
                {
                    b.HasOne("weatherapp.Alerts")
                        .WithMany("regions")
                        .HasForeignKey("Alerts_Id1");

                    b.HasOne("weatherapp.WeatherData")
                        .WithMany("alerts")
                        .HasForeignKey("WeatherDataCall_Id");
                });

            modelBuilder.Entity("weatherapp.Days", b =>
                {
                    b.HasOne("weatherapp.Daily")
                        .WithMany("days")
                        .HasForeignKey("Daily_Id");
                });

            modelBuilder.Entity("weatherapp.Flags", b =>
                {
                    b.HasOne("weatherapp.Flags")
                        .WithMany("sources")
                        .HasForeignKey("FlagsFlag_Id");
                });

            modelBuilder.Entity("weatherapp.WeatherData", b =>
                {
                    b.HasOne("weatherapp.Currently", "currently")
                        .WithMany()
                        .HasForeignKey("Currently_Id");

                    b.HasOne("weatherapp.Daily", "daily")
                        .WithMany()
                        .HasForeignKey("Daily_Id");

                    b.HasOne("weatherapp.Flags", "flags")
                        .WithMany()
                        .HasForeignKey("flagsFlag_Id");
                });
#pragma warning restore 612, 618
        }
    }
}
