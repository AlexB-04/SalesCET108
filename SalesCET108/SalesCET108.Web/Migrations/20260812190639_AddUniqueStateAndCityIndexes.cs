using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesCET108.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueStateAndCityIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_States_Name_CountryId",
                table: "States",
                columns: new[] { "Name", "CountryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name_StateId",
                table: "Cities",
                columns: new[] { "Name", "StateId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_States_Name_CountryId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_Cities_Name_StateId",
                table: "Cities");
        }
    }
}
