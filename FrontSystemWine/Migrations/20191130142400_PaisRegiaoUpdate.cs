using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontSystemWine.Migrations
{
    public partial class PaisRegiaoUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regioes_Paises_PaisId",
                table: "Regioes");

            migrationBuilder.DropIndex(
                name: "IX_Regioes_PaisId",
                table: "Regioes");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Regioes");

            migrationBuilder.AddColumn<int>(
                name: "IdPais",
                table: "Regioes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Regioes_IdPais",
                table: "Regioes",
                column: "IdPais");

            migrationBuilder.AddForeignKey(
                name: "FK_Regioes_Paises_IdPais",
                table: "Regioes",
                column: "IdPais",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regioes_Paises_IdPais",
                table: "Regioes");

            migrationBuilder.DropIndex(
                name: "IX_Regioes_IdPais",
                table: "Regioes");

            migrationBuilder.DropColumn(
                name: "IdPais",
                table: "Regioes");

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Regioes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Regioes_PaisId",
                table: "Regioes",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regioes_Paises_PaisId",
                table: "Regioes",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
