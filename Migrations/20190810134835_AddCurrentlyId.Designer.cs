﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using weatherapp;

namespace weatherapp.Migrations
{
    [DbContext(typeof(WeatherContext))]
    [Migration("20190810134835_AddCurrentlyId")]
    partial class AddCurrentlyId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("weatherapp.AlertData", b =>
                {
                    b.Property<int>("alert_data_key")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlertsAlert_Id");

                    b.Property<int?>("AlertsAlert_Id1");

                    b.Property<string>("alert_time");

                    b.Property<string>("alert_title");

                    b.Property<string>("severity");

                    b.HasKey("alert_data_key");

                    b.HasIndex("AlertsAlert_Id");

                    b.HasIndex("AlertsAlert_Id1");

                    b.ToTable("AlertData");
                });

            modelBuilder.Entity("weatherapp.Alerts", b =>
                {
                    b.Property<int>("Alert_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("weatherdata_key");

                    b.HasKey("Alert_Id");

                    b.HasIndex("weatherdata_key");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("weatherapp.Currently", b =>
                {
                    b.Property<int>("Currently_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<int>("Daily_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("icon");

                    b.Property<string>("summary");

                    b.HasKey("Daily_Id");

                    b.ToTable("Daily");
                });

            modelBuilder.Entity("weatherapp.Days", b =>
                {
                    b.Property<int>("Days_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Daily_Id");

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
                    b.Property<int>("Flags_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("units");

                    b.HasKey("Flags_Id");

                    b.ToTable("Flags");
                });

            modelBuilder.Entity("weatherapp.Region", b =>
                {
                    b.Property<int>("Region_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlertDataalert_data_key");

                    b.Property<string>("region_value");

                    b.HasKey("Region_Id");

                    b.HasIndex("AlertDataalert_data_key");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("weatherapp.Sources", b =>
                {
                    b.Property<int>("Sources_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Flags_Id");

                    b.Property<string>("sources_value");

                    b.HasKey("Sources_Id");

                    b.HasIndex("Flags_Id");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("weatherapp.WeatherData", b =>
                {
                    b.Property<int>("weatherdata_key")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Currently_Id");

                    b.Property<int?>("Daily_Id");

                    b.Property<int?>("Flags_Id");

                    b.Property<double>("latitude");

                    b.Property<double>("longitude");

                    b.Property<int?>("offset");

                    b.Property<string>("timezone");

                    b.HasKey("weatherdata_key");

                    b.HasIndex("Currently_Id");

                    b.HasIndex("Daily_Id");

                    b.HasIndex("Flags_Id");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("weatherapp.AlertData", b =>
                {
                    b.HasOne("weatherapp.Alerts")
                        .WithMany("alerts1")
                        .HasForeignKey("AlertsAlert_Id");

                    b.HasOne("weatherapp.Alerts")
                        .WithMany("data")
                        .HasForeignKey("AlertsAlert_Id1");
                });

            modelBuilder.Entity("weatherapp.Alerts", b =>
                {
                    b.HasOne("weatherapp.WeatherData")
                        .WithMany("alerts")
                        .HasForeignKey("weatherdata_key");
                });

            modelBuilder.Entity("weatherapp.Days", b =>
                {
                    b.HasOne("weatherapp.Daily")
                        .WithMany("data")
                        .HasForeignKey("Daily_Id");
                });

            modelBuilder.Entity("weatherapp.Region", b =>
                {
                    b.HasOne("weatherapp.AlertData")
                        .WithMany("region")
                        .HasForeignKey("AlertDataalert_data_key");
                });

            modelBuilder.Entity("weatherapp.Sources", b =>
                {
                    b.HasOne("weatherapp.Flags")
                        .WithMany("sources_value")
                        .HasForeignKey("Flags_Id");
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
                        .HasForeignKey("Flags_Id");
                });
#pragma warning restore 612, 618
        }
    }
}
