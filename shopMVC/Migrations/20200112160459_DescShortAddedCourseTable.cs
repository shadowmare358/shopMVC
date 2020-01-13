using Microsoft.EntityFrameworkCore.Migrations;

namespace shopMVC.Migrations
{
    public partial class DescShortAddedCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescShort",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescShort",
                table: "Courses");
        }
    }
}
