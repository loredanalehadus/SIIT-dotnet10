using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bakeries",
                columns: table => new
                {
                    BakeryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BakeryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakeries", x => x.BakeryId);
                });

            migrationBuilder.CreateTable(
                name: "Cupcakes",
                columns: table => new
                {
                    CupcakeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CupcakeType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GlutenFree = table.Column<bool>(type: "bit", nullable: false),
                    CaloricValue = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BakeryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupcakes", x => x.CupcakeId);
                    table.ForeignKey(
                        name: "FK_Cupcakes_Bakeries_BakeryId",
                        column: x => x.BakeryId,
                        principalTable: "Bakeries",
                        principalColumn: "BakeryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bakeries",
                columns: new[] { "BakeryId", "Address", "BakeryName", "Quantity" },
                values: new object[,]
                {
                    { 1, "635 Brighton Circle Road", "Gluteus Free", 8 },
                    { 2, "4323 Jerome Avenue", "Cupcakes Break", 22 },
                    { 3, "2553 Pin Oak Drive", "Cupcakes Ahead", 18 },
                    { 4, "1608 Charles Street", "Sugar", 30 }
                });

            migrationBuilder.InsertData(
                table: "Cupcakes",
                columns: new[] { "CupcakeId", "BakeryId", "CaloricValue", "CupcakeType", "Description", "GlutenFree", "Price" },
                values: new object[,]
                {
                    { 1, 1, 355, 0, "Vanilla cupcake with coconut cream", true, 2.5 },
                    { 2, 2, 195, 2, "Chocolate cupcake with caramel filling and chocolate butter cream", false, 3.2000000000000002 },
                    { 3, 3, 295, 3, "Chocolate cupcake with straberry cream filling", false, 4.0 },
                    { 4, 4, 360, 1, "Vanilla cupcake with butter cream", true, 1.5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cupcakes_BakeryId",
                table: "Cupcakes",
                column: "BakeryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cupcakes");

            migrationBuilder.DropTable(
                name: "Bakeries");
        }
    }
}
