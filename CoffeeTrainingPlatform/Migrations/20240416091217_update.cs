using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeTrainingPlatform.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Progress",
                newName: "TestId");

            migrationBuilder.AlterColumn<int>(
                name: "ProgressPercent",
                table: "Progress",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "Progress",
                newName: "CourseId");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProgressPercent",
                table: "Progress",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
