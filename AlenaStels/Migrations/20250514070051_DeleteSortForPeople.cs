using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlenaStels.Migrations
{
    /// <inheritdoc />
    public partial class DeleteSortForPeople : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortIndex",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortIndex",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
