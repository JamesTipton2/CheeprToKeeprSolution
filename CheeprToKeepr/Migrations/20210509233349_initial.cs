using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeprToKeepr.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseCategory",
                columns: table => new
                {
                    ExpenseCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseCategory", x => x.ExpenseCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ServicesCategory",
                columns: table => new
                {
                    ServicesCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesCategory", x => x.ServicesCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "VendorsCategory",
                columns: table => new
                {
                    VendorCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorsCategory", x => x.VendorCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MakeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMileage = table.Column<int>(type: "int", nullable: false),
                    GasByGallons = table.Column<int>(type: "int", nullable: false),
                    TireMileage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleID);
                    table.ForeignKey(
                        name: "FK_Vehicle_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorsCategoryID = table.Column<int>(type: "int", nullable: false),
                    VendorCategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorID);
                    table.ForeignKey(
                        name: "FK_Vendors_VendorsCategory_VendorCategoryID",
                        column: x => x.VendorCategoryID,
                        principalTable: "VendorsCategory",
                        principalColumn: "VendorCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    ExpenseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseCategoryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpenseDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.ExpenseID);
                    table.ForeignKey(
                        name: "FK_Expense_ExpenseCategory_ExpenseCategoryID",
                        column: x => x.ExpenseCategoryID,
                        principalTable: "ExpenseCategory",
                        principalColumn: "ExpenseCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expense_Vehicle_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServicesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    ServicesCategoryID = table.Column<int>(type: "int", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleMilesAtService = table.Column<int>(type: "int", nullable: true),
                    VendorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServicesID);
                    table.ForeignKey(
                        name: "FK_Service_ServicesCategory_ServicesCategoryID",
                        column: x => x.ServicesCategoryID,
                        principalTable: "ServicesCategory",
                        principalColumn: "ServicesCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Vehicle_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Vendors_VendorID",
                        column: x => x.VendorID,
                        principalTable: "Vendors",
                        principalColumn: "VendorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expense_ExpenseCategoryID",
                table: "Expense",
                column: "ExpenseCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_VehicleID",
                table: "Expense",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ServicesCategoryID",
                table: "Service",
                column: "ServicesCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_VehicleID",
                table: "Service",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_VendorID",
                table: "Service",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_UserID",
                table: "Vehicle",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_VendorCategoryID",
                table: "Vendors",
                column: "VendorCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "ExpenseCategory");

            migrationBuilder.DropTable(
                name: "ServicesCategory");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "VendorsCategory");
        }
    }
}
