using Microsoft.EntityFrameworkCore.Migrations;

namespace AmalCollections.Migrations
{
    public partial class _0610202002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CookieId",
                table: "Carts");

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "Cookie",
                table: "Carts",
                maxLength: 450,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cookie",
                table: "Carts");

            migrationBuilder.AlterColumn<double>(
                name: "Stock",
                table: "OrderDetails",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Qty",
                table: "OrderDetails",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "CookieId",
                table: "Carts",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);
        }
    }
}
