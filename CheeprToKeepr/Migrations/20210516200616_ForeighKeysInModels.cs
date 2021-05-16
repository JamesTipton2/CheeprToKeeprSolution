using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeprToKeepr.Migrations
{
    public partial class ForeighKeysInModels : Migration
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

            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_VendorsCategory_VendorCategoryID",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_VendorCategoryID",
                table: "Vendors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_ServicesCategoryID",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "VendorCategoryID",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "ServicesCategoryID",
                table: "Service");

            migrationBuilder.RenameColumn(
                name: "ServicesCategoryID",
                table: "ServicesCategory",
                newName: "ServiceCategoryID");

            migrationBuilder.RenameColumn(
                name: "ServicesID",
                table: "Service",
                newName: "ServiceCategoryID");

            migrationBuilder.AlterColumn<string>(
                name: "VendorType",
                table: "VendorsCategory",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Vendors",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vendors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Vendors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceType",
                table: "ServicesCategory",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                name: "ServiceCategoryID",
                table: "Service",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ServiceID",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ExpenseType",
                table: "ExpenseCategory",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_VendorsCategoryID",
                table: "Vendors",
                column: "VendorsCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ServiceCategoryID",
                table: "Service",
                column: "ServiceCategoryID");

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
                name: "FK_Service_ServicesCategory_ServiceCategoryID",
                table: "Service",
                column: "ServiceCategoryID",
                principalTable: "ServicesCategory",
                principalColumn: "ServiceCategoryID",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_VendorsCategory_VendorsCategoryID",
                table: "Vendors",
                column: "VendorsCategoryID",
                principalTable: "VendorsCategory",
                principalColumn: "VendorCategoryID",
                onDelete: ReferentialAction.Cascade);
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
                name: "FK_Service_ServicesCategory_ServiceCategoryID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Vehicle_VehicleID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Vendors_VendorID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_VendorsCategory_VendorsCategoryID",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_VendorsCategoryID",
                table: "Vendors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_ServiceCategoryID",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ServiceID",
                table: "Service");

            migrationBuilder.RenameColumn(
                name: "ServiceCategoryID",
                table: "ServicesCategory",
                newName: "ServicesCategoryID");

            migrationBuilder.RenameColumn(
                name: "ServiceCategoryID",
                table: "Service",
                newName: "ServicesID");

            migrationBuilder.AlterColumn<string>(
                name: "VendorType",
                table: "VendorsCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "VendorCategoryID",
                table: "Vendors",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceType",
                table: "ServicesCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
                name: "ServicesID",
                table: "Service",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ServicesCategoryID",
                table: "Service",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpenseType",
                table: "ExpenseCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "ServicesID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_VendorCategoryID",
                table: "Vendors",
                column: "VendorCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ServicesCategoryID",
                table: "Service",
                column: "ServicesCategoryID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_VendorsCategory_VendorCategoryID",
                table: "Vendors",
                column: "VendorCategoryID",
                principalTable: "VendorsCategory",
                principalColumn: "VendorCategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
