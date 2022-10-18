using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMDBSWA.Core.Migrations
{
    public partial class UpdatedFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Overview",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Overview",
                table: "Movie");
        }
    }
}
