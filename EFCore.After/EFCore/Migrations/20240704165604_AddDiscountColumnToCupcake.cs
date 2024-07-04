using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscountColumnToCupcake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "Cupcakes",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cupcakes",
                keyColumn: "CupcakeId",
                keyValue: 1,
                column: "Discount",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "Cupcakes",
                keyColumn: "CupcakeId",
                keyValue: 2,
                column: "Discount",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Cupcakes",
                keyColumn: "CupcakeId",
                keyValue: 3,
                column: "Discount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cupcakes",
                keyColumn: "CupcakeId",
                keyValue: 4,
                column: "Discount",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Cupcakes");
        }
    }
}
