using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesCET108.Web.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUniqueIndexFromCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Countries_Name",
                table: "Countries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Countries_Name",
                table: "Countries",
                column: "Name",
                unique: true);
        }
    }
}
