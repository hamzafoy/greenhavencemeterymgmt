using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenhavenMgmt.Migrations
{
    public partial class AlteredSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "birthDay",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "birthMonth",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "deathDay",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "deathMonth",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "birthDay",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "birthMonth",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "deathDay",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "deathMonth",
                table: "Person");
        }
    }
}
