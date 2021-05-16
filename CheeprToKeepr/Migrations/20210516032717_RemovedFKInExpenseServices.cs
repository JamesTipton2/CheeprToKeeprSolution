using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeprToKeepr.Migrations
{
    public partial class RemovedFKInExpenseServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_ExpenseCategory_ExpenseCategoryID",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Vehicle_VehicleID",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_ServicesCategory_ServicesCategoryID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Vehicle_VehicleID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Vendors_VendorID",
                table: "Service");

            migrationBuilder.AlterColumn<int>(
                name: "VendorID",
                table: "Service",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleID",
                table: "Service",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ServicesCategoryID",
                table: "Service",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleID",
                table: "Expense",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExpenseCategoryID",
                table: "Expense",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_ExpenseCategory_ExpenseCategoryID",
                table: "Expense",
                column: "ExpenseCategoryID",
                principalTable: "ExpenseCategory",
                principalColumn: "ExpenseCategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Vehicle_VehicleID",
                table: "Expense",
                column: "VehicleID",
                principalTable: "Vehicle",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_ServicesCategory_ServicesCategoryID",
                table: "Service",
                column: "ServicesCategoryID",
                principalTable: "ServicesCategory",
                principalColumn: "ServicesCategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Vehicle_VehicleID",
                table: "Service",
                column: "VehicleID",
                principalTable: "Vehicle",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Vendors_VendorID",
                table: "Service",
                column: "VendorID",
                principalTable: "Vendors",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_ExpenseCategory_ExpenseCategoryID",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Vehicle_VehicleID",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_ServicesCategory_ServicesCategoryID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Vehicle_VehicleID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Vendors_VendorID",
                table: "Service");

            migrationBuilder.AlterColumn<int>(
                name: "VendorID",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleID",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServicesCategoryID",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleID",
                table: "Expense",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExpenseCategoryID",
                table: "Expense",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_ExpenseCategory_ExpenseCategoryID",
                table: "Expense",
                column: "ExpenseCategoryID",
                principalTable: "ExpenseCategory",
                principalColumn: "ExpenseCategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Vehicle_VehicleID",
                table: "Expense",
                column: "VehicleID",
                principalTable: "Vehicle",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_ServicesCategory_ServicesCategoryID",
                table: "Service",
                column: "ServicesCategoryID",
                principalTable: "ServicesCategory",
                principalColumn: "ServicesCategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Vehicle_VehicleID",
                table: "Service",
                column: "VehicleID",
                principalTable: "Vehicle",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Vendors_VendorID",
                table: "Service",
                column: "VendorID",
                principalTable: "Vendors",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
