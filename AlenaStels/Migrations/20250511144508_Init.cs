using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlenaStels.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortIndex",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SortIndex",
                table: "Devices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortIndex",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SortIndex",
                table: "Devices");
        }
    }
}
