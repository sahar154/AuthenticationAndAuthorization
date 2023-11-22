using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfArch.IdentityProvider.Migrations
{
    public partial class TZ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TZ",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TZ",
                table: "AspNetUsers");
        }
    }
}
