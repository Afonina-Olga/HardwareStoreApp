using Microsoft.EntityFrameworkCore.Migrations;

namespace HardwareStoreApp.Migrations
{
    public partial class ModifyStoreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Balances_BalanceId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Balances_BalanceId",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Sales_SaleId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_BalanceId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_SaleId",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "BalanceId",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "Stores");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Stores",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BalanceId",
                table: "Sales",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Sales",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_StoreId",
                table: "Sales",
                column: "StoreId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Balances_StoreId",
                table: "Balances",
                column: "StoreId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Balances_Stores_StoreId",
                table: "Balances",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Balances_BalanceId",
                table: "Sales",
                column: "BalanceId",
                principalTable: "Balances",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balances_Stores_StoreId",
                table: "Balances");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Balances_BalanceId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Stores_StoreId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_StoreId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Balances_StoreId",
                table: "Balances");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "BalanceId",
                table: "Stores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "Stores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "BalanceId",
                table: "Sales",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_BalanceId",
                table: "Stores",
                column: "BalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stores_SaleId",
                table: "Stores",
                column: "SaleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Balances_BalanceId",
                table: "Sales",
                column: "BalanceId",
                principalTable: "Balances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Balances_BalanceId",
                table: "Stores",
                column: "BalanceId",
                principalTable: "Balances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Sales_SaleId",
                table: "Stores",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
