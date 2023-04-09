using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleTask.Migrations
{
    public partial class CreatTableIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsActive",
                table: "SliderInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SliderId",
                table: "SliderInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SliderInfos_SliderId",
                table: "SliderInfos",
                column: "SliderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SliderInfos_Sliders_SliderId",
                table: "SliderInfos",
                column: "SliderId",
                principalTable: "Sliders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SliderInfos_Sliders_SliderId",
                table: "SliderInfos");

            migrationBuilder.DropIndex(
                name: "IX_SliderInfos_SliderId",
                table: "SliderInfos");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "SliderInfos");

            migrationBuilder.DropColumn(
                name: "SliderId",
                table: "SliderInfos");
        }
    }
}
