using Microsoft.EntityFrameworkCore.Migrations;

namespace HardwareStoreApp.Migrations
{
    public partial class BalanceRelationsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Balance",
                table: "Balance");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Balance",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Balance",
                table: "Balance",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Balance_StoreId",
                table: "Balance",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Balance",
                table: "Balance");

            migrationBuilder.DropIndex(
                name: "IX_Balance_StoreId",
                table: "Balance");

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
        }
    }
}
