using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontSystemWine.Migrations
{
    public partial class Armonizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdArmonizacao",
                table: "Vinhos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Armonizacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armonizacoes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vinhos_IdArmonizacao",
                table: "Vinhos",
                column: "IdArmonizacao");

            migrationBuilder.AddForeignKey(
                name: "FK_Vinhos_Armonizacoes_IdArmonizacao",
                table: "Vinhos",
                column: "IdArmonizacao",
                principalTable: "Armonizacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vinhos_Armonizacoes_IdArmonizacao",
                table: "Vinhos");

            migrationBuilder.DropTable(
                name: "Armonizacoes");

            migrationBuilder.DropIndex(
                name: "IX_Vinhos_IdArmonizacao",
                table: "Vinhos");

            migrationBuilder.DropColumn(
                name: "IdArmonizacao",
                table: "Vinhos");
        }
    }
}
