using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleTask.Migrations
{
    public partial class CreatImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ContactMembers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ContactMembers");
        }
    }
}
