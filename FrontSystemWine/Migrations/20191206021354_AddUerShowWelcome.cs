using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontSystemWine.Migrations
{
    public partial class AddUerShowWelcome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MostrarBoasVindas",
                table: "UsuarioPreferencias",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MostrarBoasVindas",
                table: "UsuarioPreferencias");
        }
    }
}
