using Microsoft.EntityFrameworkCore.Migrations;

namespace RGCAPP.Data.Migrations
{
    public partial class JobLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobLocation",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobLocation",
                table: "Employee");
        }
    }
}
