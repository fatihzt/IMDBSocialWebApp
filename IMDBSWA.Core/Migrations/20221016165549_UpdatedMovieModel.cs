using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMDBSWA.Core.Migrations
{
    public partial class UpdatedMovieModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundPath",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstAirDate",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OriginCountry",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OriginalLanguage",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Overview",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PosterPath",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TvSeriesId",
                table: "TvSeries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Adult",
                table: "Movie",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "BackgroundPath",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "Budget",
                table: "Movie",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "PosterPath",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Runtime",
                table: "Movie",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundPath",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "FirstAirDate",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "OriginCountry",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "OriginalLanguage",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "Overview",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "PosterPath",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "TvSeriesId",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "Adult",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "BackgroundPath",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "PosterPath",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Runtime",
                table: "Movie");
        }
    }
}
