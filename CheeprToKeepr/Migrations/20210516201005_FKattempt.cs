using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeprToKeepr.Migrations
{
    public partial class FKattempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_VendorsCategory_VendorsCategoryID",
                table: "Vendors");

            migrationBuilder.AlterColumn<int>(
                name: "VendorsCategoryID",
                table: "Vendors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "VendorCategoryID",
                table: "Vendors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_VendorsCategory_VendorsCategoryID",
                table: "Vendors",
                column: "VendorsCategoryID",
                principalTable: "VendorsCategory",
                principalColumn: "VendorCategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_VendorsCategory_VendorsCategoryID",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "VendorCategoryID",
                table: "Vendors");

            migrationBuilder.AlterColumn<int>(
                name: "VendorsCategoryID",
                table: "Vendors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_VendorsCategory_VendorsCategoryID",
                table: "Vendors",
                column: "VendorsCategoryID",
                principalTable: "VendorsCategory",
                principalColumn: "VendorCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
