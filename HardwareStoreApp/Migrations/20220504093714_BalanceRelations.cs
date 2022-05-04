using Microsoft.EntityFrameworkCore.Migrations;

namespace HardwareStoreApp.Migrations
{
    public partial class BalanceRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balances_Products_ProductId",
                table: "Balances");

            migrationBuilder.DropForeignKey(
                name: "FK_Balances_Stores_StoreId",
                table: "Balances");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Balances_BalanceId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_BalanceId",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Balances",
                table: "Balances");

            migrationBuilder.DropIndex(
                name: "IX_Balances_StoreId",
                table: "Balances");

            migrationBuilder.DropColumn(
                name: "BalanceId",
                table: "Sales");

            migrationBuilder.RenameTable(
                name: "Balances",
                newName: "Balance");

            migrationBuilder.RenameIndex(
                name: "IX_Balances_ProductId",
                table: "Balance",
                newName: "IX_Balance_ProductId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Balance",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Balance",
                table: "Balance",
                columns: new[] { "StoreId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Balance_Products_ProductId",
                table: "Balance",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Balance_Stores_StoreId",
                table: "Balance",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balance_Products_ProductId",
                table: "Balance");

            migrationBuilder.DropForeignKey(
                name: "FK_Balance_Stores_StoreId",
                table: "Balance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Balance",
                table: "Balance");

            migrationBuilder.RenameTable(
                name: "Balance",
                newName: "Balances");

            migrationBuilder.RenameIndex(
                name: "IX_Balance_ProductId",
                table: "Balances",
                newName: "IX_Balances_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "BalanceId",
                table: "Sales",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Balances",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Balances",
                table: "Balances",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_BalanceId",
                table: "Sales",
                column: "BalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Balances_StoreId",
                table: "Balances",
                column: "StoreId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Balances_Products_ProductId",
                table: "Balances",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
        }
    }
}
