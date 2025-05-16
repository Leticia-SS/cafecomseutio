using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeComSeuTioAdmin.Migrations
{
    /// <inheritdoc />
    public partial class ProductDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductDetail",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TechnicalSpecs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLimitedEdition = table.Column<bool>(type: "bit", nullable: false),
                    LauchDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetail", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetail");
        }
    }
}
