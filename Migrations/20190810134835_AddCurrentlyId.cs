using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace weatherapp.Migrations
{
    public partial class AddCurrentlyId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alerts_Alerts_Alerts_Id1",
                table: "Alerts");

            migrationBuilder.DropForeignKey(
                name: "FK_Alerts_Weather_WeatherDataCall_Id",
                table: "Alerts");

            migrationBuilder.DropForeignKey(
                name: "FK_Flags_Flags_FlagsFlag_Id",
                table: "Flags");

            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Flags_flagsFlag_Id",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weather",
                table: "Weather");

            migrationBuilder.DropIndex(
                name: "IX_Weather_flagsFlag_Id",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flags",
                table: "Flags");

            migrationBuilder.DropIndex(
                name: "IX_Flags_FlagsFlag_Id",
                table: "Flags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alerts",
                table: "Alerts");

            migrationBuilder.DropIndex(
                name: "IX_Alerts_Alerts_Id1",
                table: "Alerts");

            migrationBuilder.DropIndex(
                name: "IX_Alerts_WeatherDataCall_Id",
                table: "Alerts");

            migrationBuilder.DropColumn(
                name: "Call_Id",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "flagsFlag_Id",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "Flag_Id",
                table: "Flags");

            migrationBuilder.DropColumn(
                name: "FlagsFlag_Id",
                table: "Flags");

            migrationBuilder.DropColumn(
                name: "Alerts_Id",
                table: "Alerts");

            migrationBuilder.DropColumn(
                name: "Alerts_Id1",
                table: "Alerts");

            migrationBuilder.DropColumn(
                name: "WeatherDataCall_Id",
                table: "Alerts");

            migrationBuilder.DropColumn(
                name: "alert_time",
                table: "Alerts");

            migrationBuilder.DropColumn(
                name: "alert_title",
                table: "Alerts");

            migrationBuilder.DropColumn(
                name: "severity",
                table: "Alerts");

            migrationBuilder.AlterColumn<int>(
                name: "Daily_Id",
                table: "Weather",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Currently_Id",
                table: "Weather",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "weatherdata_key",
                table: "Weather",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Flags_Id",
                table: "Weather",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Flags_Id",
                table: "Flags",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Daily_Id",
                table: "Days",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Days_Id",
                table: "Days",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Daily_Id",
                table: "Daily",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Currently_Id",
                table: "Currently",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Alert_Id",
                table: "Alerts",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "weatherdata_key",
                table: "Alerts",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weather",
                table: "Weather",
                column: "weatherdata_key");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flags",
                table: "Flags",
                column: "Flags_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alerts",
                table: "Alerts",
                column: "Alert_Id");

            migrationBuilder.CreateTable(
                name: "AlertData",
                columns: table => new
                {
                    alert_data_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    alert_title = table.Column<string>(nullable: true),
                    severity = table.Column<string>(nullable: true),
                    alert_time = table.Column<string>(nullable: true),
                    AlertsAlert_Id = table.Column<int>(nullable: true),
                    AlertsAlert_Id1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertData", x => x.alert_data_key);
                    table.ForeignKey(
                        name: "FK_AlertData_Alerts_AlertsAlert_Id",
                        column: x => x.AlertsAlert_Id,
                        principalTable: "Alerts",
                        principalColumn: "Alert_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlertData_Alerts_AlertsAlert_Id1",
                        column: x => x.AlertsAlert_Id1,
                        principalTable: "Alerts",
                        principalColumn: "Alert_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Sources_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sources_value = table.Column<string>(nullable: true),
                    Flags_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Sources_Id);
                    table.ForeignKey(
                        name: "FK_Sources_Flags_Flags_Id",
                        column: x => x.Flags_Id,
                        principalTable: "Flags",
                        principalColumn: "Flags_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Region_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    region_value = table.Column<string>(nullable: true),
                    AlertDataalert_data_key = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Region_Id);
                    table.ForeignKey(
                        name: "FK_Region_AlertData_AlertDataalert_data_key",
                        column: x => x.AlertDataalert_data_key,
                        principalTable: "AlertData",
                        principalColumn: "alert_data_key",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weather_Flags_Id",
                table: "Weather",
                column: "Flags_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_weatherdata_key",
                table: "Alerts",
                column: "weatherdata_key");

            migrationBuilder.CreateIndex(
                name: "IX_AlertData_AlertsAlert_Id",
                table: "AlertData",
                column: "AlertsAlert_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AlertData_AlertsAlert_Id1",
                table: "AlertData",
                column: "AlertsAlert_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Region_AlertDataalert_data_key",
                table: "Region",
                column: "AlertDataalert_data_key");

            migrationBuilder.CreateIndex(
                name: "IX_Sources_Flags_Id",
                table: "Sources",
                column: "Flags_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alerts_Weather_weatherdata_key",
                table: "Alerts",
                column: "weatherdata_key",
                principalTable: "Weather",
                principalColumn: "weatherdata_key",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Flags_Flags_Id",
                table: "Weather",
                column: "Flags_Id",
                principalTable: "Flags",
                principalColumn: "Flags_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alerts_Weather_weatherdata_key",
                table: "Alerts");

            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Flags_Flags_Id",
                table: "Weather");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "AlertData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weather",
                table: "Weather");

            migrationBuilder.DropIndex(
                name: "IX_Weather_Flags_Id",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flags",
                table: "Flags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alerts",
                table: "Alerts");

            migrationBuilder.DropIndex(
                name: "IX_Alerts_weatherdata_key",
                table: "Alerts");

            migrationBuilder.DropColumn(
                name: "weatherdata_key",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "Flags_Id",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "Flags_Id",
                table: "Flags");

            migrationBuilder.DropColumn(
                name: "Alert_Id",
                table: "Alerts");

            migrationBuilder.DropColumn(
                name: "weatherdata_key",
                table: "Alerts");

            migrationBuilder.AlterColumn<string>(
                name: "Daily_Id",
                table: "Weather",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Currently_Id",
                table: "Weather",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Call_Id",
                table: "Weather",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "flagsFlag_Id",
                table: "Weather",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Flag_Id",
                table: "Flags",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FlagsFlag_Id",
                table: "Flags",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Daily_Id",
                table: "Days",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Days_Id",
                table: "Days",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Daily_Id",
                table: "Daily",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Currently_Id",
                table: "Currently",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Alerts_Id",
                table: "Alerts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Alerts_Id1",
                table: "Alerts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherDataCall_Id",
                table: "Alerts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "alert_time",
                table: "Alerts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "alert_title",
                table: "Alerts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "severity",
                table: "Alerts",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weather",
                table: "Weather",
                column: "Call_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flags",
                table: "Flags",
                column: "Flag_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alerts",
                table: "Alerts",
                column: "Alerts_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_flagsFlag_Id",
                table: "Weather",
                column: "flagsFlag_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Flags_FlagsFlag_Id",
                table: "Flags",
                column: "FlagsFlag_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_Alerts_Id1",
                table: "Alerts",
                column: "Alerts_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_WeatherDataCall_Id",
                table: "Alerts",
                column: "WeatherDataCall_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alerts_Alerts_Alerts_Id1",
                table: "Alerts",
                column: "Alerts_Id1",
                principalTable: "Alerts",
                principalColumn: "Alerts_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alerts_Weather_WeatherDataCall_Id",
                table: "Alerts",
                column: "WeatherDataCall_Id",
                principalTable: "Weather",
                principalColumn: "Call_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flags_Flags_FlagsFlag_Id",
                table: "Flags",
                column: "FlagsFlag_Id",
                principalTable: "Flags",
                principalColumn: "Flag_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Flags_flagsFlag_Id",
                table: "Weather",
                column: "flagsFlag_Id",
                principalTable: "Flags",
                principalColumn: "Flag_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
