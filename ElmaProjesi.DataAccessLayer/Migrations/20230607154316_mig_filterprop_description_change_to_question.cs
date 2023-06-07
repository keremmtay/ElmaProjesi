using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElmaProjesi.DataAccessLayer.Migrations
{
    public partial class mig_filterprop_description_change_to_question : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Filters",
                newName: "Question");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Question",
                table: "Filters",
                newName: "Description");
        }
    }
}
