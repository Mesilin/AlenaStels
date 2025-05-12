using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlenaStels.Migrations
{
    /// <inheritdoc />
    public partial class ChangeWorkLogTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "WorkLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "WorkLogs");
        }
    }
}
