using Microsoft.EntityFrameworkCore.Migrations;

namespace weatherapp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currently",
                columns: table => new
                {
                    Currently_Id = table.Column<string>(nullable: false),
                    time = table.Column<string>(nullable: true),
                    summary = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true),
                    nearestStormDistance = table.Column<double>(nullable: false),
                    nearestStormBearing = table.Column<double>(nullable: false),
                    precipIntensity = table.Column<double>(nullable: false),
                    precipProbability = table.Column<double>(nullable: false),
                    temperature = table.Column<double>(nullable: false),
                    apparentTemperature = table.Column<double>(nullable: false),
                    dewPoint = table.Column<double>(nullable: false),
                    humidity = table.Column<double>(nullable: false),
                    pressure = table.Column<double>(nullable: false),
                    windSpeed = table.Column<double>(nullable: false),
                    windGust = table.Column<double>(nullable: false),
                    windBearing = table.Column<double>(nullable: false),
                    cloudCover = table.Column<double>(nullable: false),
                    uvIndex = table.Column<double>(nullable: false),
                    visibility = table.Column<double>(nullable: false),
                    ozone = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currently", x => x.Currently_Id);
                });

            migrationBuilder.CreateTable(
                name: "Daily",
                columns: table => new
                {
                    Daily_Id = table.Column<string>(nullable: false),
                    summary = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daily", x => x.Daily_Id);
                });

            migrationBuilder.CreateTable(
                name: "Flags",
                columns: table => new
                {
                    Flag_Id = table.Column<string>(nullable: false),
                    units = table.Column<string>(nullable: true),
                    FlagsFlag_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flags", x => x.Flag_Id);
                    table.ForeignKey(
                        name: "FK_Flags_Flags_FlagsFlag_Id",
                        column: x => x.FlagsFlag_Id,
                        principalTable: "Flags",
                        principalColumn: "Flag_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Days_Id = table.Column<string>(nullable: false),
                    time = table.Column<string>(nullable: true),
                    summary = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true),
                    sunriseTime = table.Column<string>(nullable: true),
                    sunsetTime = table.Column<string>(nullable: true),
                    moonPhase = table.Column<double>(nullable: false),
                    precipIntensity = table.Column<double>(nullable: false),
                    precipIntensityMax = table.Column<double>(nullable: false),
                    precipIntensityMaxTime = table.Column<string>(nullable: true),
                    precipProbability = table.Column<double>(nullable: false),
                    precipType = table.Column<string>(nullable: true),
                    temperatureHigh = table.Column<double>(nullable: false),
                    temperatureHighTime = table.Column<string>(nullable: true),
                    temperatureLow = table.Column<double>(nullable: false),
                    temperatureLowTime = table.Column<string>(nullable: true),
                    apparentTemperatureHigh = table.Column<double>(nullable: false),
                    apparentTemperatureHighTime = table.Column<string>(nullable: true),
                    apparentTemperatureLow = table.Column<double>(nullable: false),
                    apparentTemperatureLowTime = table.Column<string>(nullable: true),
                    dewPoint = table.Column<double>(nullable: false),
                    humidity = table.Column<double>(nullable: false),
                    pressure = table.Column<double>(nullable: false),
                    windSpeed = table.Column<double>(nullable: false),
                    windGust = table.Column<double>(nullable: false),
                    windGustTime = table.Column<string>(nullable: true),
                    windBearing = table.Column<int>(nullable: false),
                    cloudCover = table.Column<double>(nullable: false),
                    uvIndex = table.Column<int>(nullable: false),
                    uvIndexTime = table.Column<string>(nullable: true),
                    visibility = table.Column<double>(nullable: false),
                    ozone = table.Column<double>(nullable: false),
                    temperatureMin = table.Column<double>(nullable: false),
                    temperatureMinTime = table.Column<string>(nullable: true),
                    temperatureMax = table.Column<double>(nullable: false),
                    temperatureMaxTime = table.Column<string>(nullable: true),
                    apparentTemperatureMin = table.Column<double>(nullable: false),
                    apparentTemperatureMinTime = table.Column<string>(nullable: true),
                    apparentTemperatureMax = table.Column<double>(nullable: false),
                    apparentTemperatureMaxTime = table.Column<string>(nullable: true),
                    Daily_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Days_Id);
                    table.ForeignKey(
                        name: "FK_Days_Daily_Daily_Id",
                        column: x => x.Daily_Id,
                        principalTable: "Daily",
                        principalColumn: "Daily_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Call_Id = table.Column<string>(nullable: false),
                    latitude = table.Column<double>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    timezone = table.Column<string>(nullable: true),
                    Currently_Id = table.Column<string>(nullable: true),
                    Daily_Id = table.Column<string>(nullable: true),
                    flagsFlag_Id = table.Column<string>(nullable: true),
                    offset = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Call_Id);
                    table.ForeignKey(
                        name: "FK_Weather_Currently_Currently_Id",
                        column: x => x.Currently_Id,
                        principalTable: "Currently",
                        principalColumn: "Currently_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weather_Daily_Daily_Id",
                        column: x => x.Daily_Id,
                        principalTable: "Daily",
                        principalColumn: "Daily_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weather_Flags_flagsFlag_Id",
                        column: x => x.flagsFlag_Id,
                        principalTable: "Flags",
                        principalColumn: "Flag_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alerts",
                columns: table => new
                {
                    Alerts_Id = table.Column<string>(nullable: false),
                    alert_title = table.Column<string>(nullable: true),
                    severity = table.Column<string>(nullable: true),
                    alert_time = table.Column<string>(nullable: true),
                    Alerts_Id1 = table.Column<string>(nullable: true),
                    WeatherDataCall_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerts", x => x.Alerts_Id);
                    table.ForeignKey(
                        name: "FK_Alerts_Alerts_Alerts_Id1",
                        column: x => x.Alerts_Id1,
                        principalTable: "Alerts",
                        principalColumn: "Alerts_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alerts_Weather_WeatherDataCall_Id",
                        column: x => x.WeatherDataCall_Id,
                        principalTable: "Weather",
                        principalColumn: "Call_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_Alerts_Id1",
                table: "Alerts",
                column: "Alerts_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_WeatherDataCall_Id",
                table: "Alerts",
                column: "WeatherDataCall_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Days_Daily_Id",
                table: "Days",
                column: "Daily_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Flags_FlagsFlag_Id",
                table: "Flags",
                column: "FlagsFlag_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_Currently_Id",
                table: "Weather",
                column: "Currently_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_Daily_Id",
                table: "Weather",
                column: "Daily_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_flagsFlag_Id",
                table: "Weather",
                column: "flagsFlag_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alerts");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "Currently");

            migrationBuilder.DropTable(
                name: "Daily");

            migrationBuilder.DropTable(
                name: "Flags");
        }
    }
}
