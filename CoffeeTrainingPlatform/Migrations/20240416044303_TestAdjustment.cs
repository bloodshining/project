using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeTrainingPlatform.Migrations
{
    /// <inheritdoc />
    public partial class TestAdjustment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StructureId",
                table: "practiceTests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StructureId",
                table: "practiceTests",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
