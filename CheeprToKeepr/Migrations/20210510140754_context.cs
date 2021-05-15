using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeprToKeepr.Migrations
{
    public partial class context : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_UserID",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "GasByGallons",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "VehicleMileage",
                table: "Vehicle",
                newName: "Miles on vehicle");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Vehicle",
                newName: "Ower ID");

            migrationBuilder.RenameColumn(
                name: "TireMileage",
                table: "Vehicle",
                newName: "Mileage");

            migrationBuilder.RenameColumn(
                name: "ModelName2",
                table: "Vehicle",
                newName: "Trim Level, optional (EX: GT, SXT, EX)");

            migrationBuilder.RenameColumn(
                name: "ModelName1",
                table: "Vehicle",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "MakeName",
                table: "Vehicle",
                newName: "Make");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_UserID",
                table: "Vehicle",
                newName: "IX_Vehicle_Ower ID");

            migrationBuilder.AddColumn<decimal>(
                name: "MilesPerGallon",
                table: "Vehicle",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Fillup",
                columns: table => new
                {
                    FillupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    Gallons = table.Column<double>(type: "float", nullable: false),
                    MilesDriven = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fillup", x => x.FillupID);
                    table.ForeignKey(
                        name: "FK_Fillup_Vehicle_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fillup_VehicleID",
                table: "Fillup",
                column: "VehicleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_Ower ID",
                table: "Vehicle",
                column: "Ower ID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_Ower ID",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "Fillup");

            migrationBuilder.DropColumn(
                name: "MilesPerGallon",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "Trim Level, optional (EX: GT, SXT, EX)",
                table: "Vehicle",
                newName: "ModelName2");

            migrationBuilder.RenameColumn(
                name: "Ower ID",
                table: "Vehicle",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Vehicle",
                newName: "ModelName1");

            migrationBuilder.RenameColumn(
                name: "Miles on vehicle",
                table: "Vehicle",
                newName: "VehicleMileage");

            migrationBuilder.RenameColumn(
                name: "Mileage",
                table: "Vehicle",
                newName: "TireMileage");

            migrationBuilder.RenameColumn(
                name: "Make",
                table: "Vehicle",
                newName: "MakeName");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_Ower ID",
                table: "Vehicle",
                newName: "IX_Vehicle_UserID");

            migrationBuilder.AddColumn<int>(
                name: "GasByGallons",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_UserID",
                table: "Vehicle",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
