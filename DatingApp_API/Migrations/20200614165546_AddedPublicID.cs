using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp_API.Migrations
{
    public partial class AddedPublicID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PublicId",
                table: "Photos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Photos");
        }
    }
}
