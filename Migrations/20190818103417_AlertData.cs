using Microsoft.EntityFrameworkCore.Migrations;

namespace weatherapp.Migrations
{
    public partial class AlertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "AlertData",
            columns: table => new
            {
                alerts_id1 = table.Column<int>(nullable: false).Annotation("SqlServer:ValueGenerationStrategy", "IdentityColumn"),
                alert_title = table.Column<string>(nullable: true),
                region = table.Column<string>(nullable: true),
                severity = table.Column<string>(nullable: true),
                alert_time = table.Column<int>(nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Alerts_Id1", x => x.alerts_id1);
            });

            //migrationBuilder.AddColumn<int>(
            //    name: "Alerts_Id1",
            //    table: "Alerts",
            //    nullable: false,
            //    defaultValue: 0);


            migrationBuilder.AddPrimaryKey(
                name: "Alerts_Id1",
                table: "AlertData",
                column: "alerts_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_AlertDatas_Alerts_Alerts_Id",
                table: "AlertDatas",
                column: "Alerts_Id",
                principalTable: "Alerts",
                principalColumn: "Alerts_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlertDatas_Alerts_Alerts_Id1",
                table: "AlertDatas",
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
                name: "FK_Region_AlertDatas_AlertDataalerts_id1",
                table: "Region",
                column: "AlertDataalerts_id1",
                principalTable: "AlertDatas",
                principalColumn: "alerts_id1",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sources_Flags_FlagsFlag_Id",
                table: "Sources",
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

        /*protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlertDatas_Alerts_Alerts_Id",
                table: "AlertDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_AlertDatas_Alerts_Alerts_Id1",
                table: "AlertDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_Alerts_Weather_WeatherDataCall_Id",
                table: "Alerts");

            migrationBuilder.DropForeignKey(
                name: "FK_Region_AlertDatas_AlertDataalerts_id1",
                table: "Region");

            migrationBuilder.DropForeignKey(
                name: "FK_Sources_Flags_FlagsFlag_Id",
                table: "Sources");

            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Flags_flagsFlag_Id",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "Falgs_Id",
                table: "Flags");

            migrationBuilder.DropPrimaryKey(
                name: "Days_Id",
                table: "Days");

            migrationBuilder.DropPrimaryKey(
                name: "Daily_id",
                table: "Daily");

            migrationBuilder.DropPrimaryKey(
                name: "OldCurrently_Id",
                table: "Currently");

            migrationBuilder.DropPrimaryKey(
                name: "Alerts_Id",
                table: "Alerts");

            migrationBuilder.DropPrimaryKey(
                name: "Alerts_Id1",
                table: "AlertDatas");

            migrationBuilder.DropColumn(
                name: "Alerts_Id1",
                table: "Alerts");

            migrationBuilder.RenameTable(
                name: "AlertDatas",
                newName: "AlertData");

            migrationBuilder.RenameColumn(
                name: "flagsFlag_Id",
                table: "Weather",
                newName: "Flag_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Weather_flagsFlag_Id",
                table: "Weather",
                newName: "IX_Weather_Flag_Id");

            migrationBuilder.RenameColumn(
                name: "FlagsFlag_Id",
                table: "Sources",
                newName: "Flag_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Sources_FlagsFlag_Id",
                table: "Sources",
                newName: "IX_Sources_Flag_Id");

            migrationBuilder.RenameColumn(
                name: "AlertDataalerts_id1",
                table: "Region",
                newName: "AlertDataalert_data_key");

            migrationBuilder.RenameIndex(
                name: "IX_Region_AlertDataalerts_id1",
                table: "Region",
                newName: "IX_Region_AlertDataalert_data_key");

            migrationBuilder.RenameColumn(
                name: "WeatherDataCall_Id",
                table: "Alerts",
                newName: "Call_Id");

            migrationBuilder.RenameColumn(
                name: "Alerts_Id",
                table: "Alerts",
                newName: "Alert_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Alerts_WeatherDataCall_Id",
                table: "Alerts",
                newName: "IX_Alerts_Call_Id");

            migrationBuilder.RenameColumn(
                name: "Alerts_Id1",
                table: "AlertData",
                newName: "AlertsAlert_Id1");

            migrationBuilder.RenameColumn(
                name: "Alerts_Id",
                table: "AlertData",
                newName: "AlertsAlert_Id");

            migrationBuilder.RenameColumn(
                name: "alerts_id1",
                table: "AlertData",
                newName: "alert_data_key");

            migrationBuilder.RenameIndex(
                name: "IX_AlertDatas_Alerts_Id1",
                table: "AlertData",
                newName: "IX_AlertData_AlertsAlert_Id1");

            migrationBuilder.RenameIndex(
                name: "IX_AlertDatas_Alerts_Id",
                table: "AlertData",
                newName: "IX_AlertData_AlertsAlert_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flags",
                table: "Flags",
                column: "Flag_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Days",
                table: "Days",
                column: "Days_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Daily",
                table: "Daily",
                column: "Daily_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currently",
                table: "Currently",
                column: "Currently_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alerts",
                table: "Alerts",
                column: "Alert_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlertData",
                table: "AlertData",
                column: "alert_data_key");

            migrationBuilder.AddForeignKey(
                name: "FK_AlertData_Alerts_AlertsAlert_Id",
                table: "AlertData",
                column: "AlertsAlert_Id",
                principalTable: "Alerts",
                principalColumn: "Alert_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlertData_Alerts_AlertsAlert_Id1",
                table: "AlertData",
                column: "AlertsAlert_Id1",
                principalTable: "Alerts",
                principalColumn: "Alert_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alerts_Weather_Call_Id",
                table: "Alerts",
                column: "Call_Id",
                principalTable: "Weather",
                principalColumn: "Call_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Region_AlertData_AlertDataalert_data_key",
                table: "Region",
                column: "AlertDataalert_data_key",
                principalTable: "AlertData",
                principalColumn: "alert_data_key",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sources_Flags_Flag_Id",
                table: "Sources",
                column: "Flag_Id",
                principalTable: "Flags",
                principalColumn: "Flag_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Flags_Flag_Id",
                table: "Weather",
                column: "Flag_Id",
                principalTable: "Flags",
                principalColumn: "Flag_Id",
                onDelete: ReferentialAction.Restrict);
        }
        */
    }
}
