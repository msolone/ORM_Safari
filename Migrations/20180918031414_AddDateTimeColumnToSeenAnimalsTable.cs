using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ORM_Safari.Migrations
{
    public partial class AddDateTimeColumnToSeenAnimalsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastSeenTime",
                table: "SeenAnimalsTable",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastSeenTime",
                table: "SeenAnimalsTable");
        }
    }
}
