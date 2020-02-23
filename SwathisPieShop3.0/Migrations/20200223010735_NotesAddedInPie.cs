using Microsoft.EntityFrameworkCore.Migrations;

namespace SwathisPieShop3._0.Migrations
{
    public partial class NotesAddedInPie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Pies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Pies");
        }
    }
}
