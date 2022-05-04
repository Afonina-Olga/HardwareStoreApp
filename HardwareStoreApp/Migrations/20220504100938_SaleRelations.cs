using Microsoft.EntityFrameworkCore.Migrations;

namespace HardwareStoreApp.Migrations
{
    public partial class SaleRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Products_ProductId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Stores_StoreId",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_StoreId",
                table: "Sales");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_ProductId",
                table: "Sale",
                newName: "IX_Sale_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "Sale",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreId1",
                table: "Sale",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_ProductId1",
                table: "Sale",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_StoreId",
                table: "Sale",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_StoreId1",
                table: "Sale",
                column: "StoreId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Products_ProductId",
                table: "Sale",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Products_ProductId1",
                table: "Sale",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Stores_StoreId",
                table: "Sale",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Stores_StoreId1",
                table: "Sale",
                column: "StoreId1",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Products_ProductId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Products_ProductId1",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Stores_StoreId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Stores_StoreId1",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_ProductId1",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_StoreId",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_StoreId1",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "StoreId1",
                table: "Sale");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_ProductId",
                table: "Sales",
                newName: "IX_Sales_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_StoreId",
                table: "Sales",
                column: "StoreId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Products_ProductId",
                table: "Sales",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Stores_StoreId",
                table: "Sales",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
