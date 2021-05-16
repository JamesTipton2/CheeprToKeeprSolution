using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeprToKeepr.Migrations
{
    public partial class updateTabletwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_ServicesCategory_ServiceCategoryID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Vendors_VendorID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_VendorsCategory_VendorsCategoryID",
                table: "Vendors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendorsCategory",
                table: "VendorsCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendors",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_VendorsCategoryID",
                table: "Vendors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServicesCategory",
                table: "ServicesCategory");

            migrationBuilder.DropColumn(
                name: "VendorsCategoryID",
                table: "Vendors");

            migrationBuilder.RenameTable(
                name: "VendorsCategory",
                newName: "VendorCategory");

            migrationBuilder.RenameTable(
                name: "Vendors",
                newName: "Vendor");

            migrationBuilder.RenameTable(
                name: "ServicesCategory",
                newName: "ServiceCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendorCategory",
                table: "VendorCategory",
                column: "VendorCategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendor",
                table: "Vendor",
                column: "VendorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceCategory",
                table: "ServiceCategory",
                column: "ServiceCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_VendorCategoryID",
                table: "Vendor",
                column: "VendorCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_ServiceCategory_ServiceCategoryID",
                table: "Service",
                column: "ServiceCategoryID",
                principalTable: "ServiceCategory",
                principalColumn: "ServiceCategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Vendor_VendorID",
                table: "Service",
                column: "VendorID",
                principalTable: "Vendor",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_VendorCategory_VendorCategoryID",
                table: "Vendor",
                column: "VendorCategoryID",
                principalTable: "VendorCategory",
                principalColumn: "VendorCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_ServiceCategory_ServiceCategoryID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Vendor_VendorID",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_VendorCategory_VendorCategoryID",
                table: "Vendor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendorCategory",
                table: "VendorCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendor",
                table: "Vendor");

            migrationBuilder.DropIndex(
                name: "IX_Vendor_VendorCategoryID",
                table: "Vendor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceCategory",
                table: "ServiceCategory");

            migrationBuilder.RenameTable(
                name: "VendorCategory",
                newName: "VendorsCategory");

            migrationBuilder.RenameTable(
                name: "Vendor",
                newName: "Vendors");

            migrationBuilder.RenameTable(
                name: "ServiceCategory",
                newName: "ServicesCategory");

            migrationBuilder.AddColumn<int>(
                name: "VendorsCategoryID",
                table: "Vendors",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendorsCategory",
                table: "VendorsCategory",
                column: "VendorCategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendors",
                table: "Vendors",
                column: "VendorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServicesCategory",
                table: "ServicesCategory",
                column: "ServiceCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_VendorsCategoryID",
                table: "Vendors",
                column: "VendorsCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_ServicesCategory_ServiceCategoryID",
                table: "Service",
                column: "ServiceCategoryID",
                principalTable: "ServicesCategory",
                principalColumn: "ServiceCategoryID",
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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
