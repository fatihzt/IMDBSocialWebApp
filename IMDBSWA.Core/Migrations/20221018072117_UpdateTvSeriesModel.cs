using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMDBSWA.Core.Migrations
{
    public partial class UpdateTvSeriesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginCountry",
                table: "TvSeries");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstAirDate",
                table: "TvSeries",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "OriginTitle",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginTitle",
                table: "TvSeries");

            migrationBuilder.AlterColumn<string>(
                name: "FirstAirDate",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginCountry",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
