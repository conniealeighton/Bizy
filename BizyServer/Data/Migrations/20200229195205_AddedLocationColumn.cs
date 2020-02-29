using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace BizyServer.Data.Migrations
{
    public partial class AddedLocationColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Point>(
                name: "LastLocation",
                table: "ApplicationUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLocation",
                table: "ApplicationUsers");
        }
    }
}
