using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontSystemWine.Migrations
{
    public partial class AddVinhoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vinhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    IdRegiao = table.Column<int>(nullable: false),
                    IdTipoUva = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    IdTipoVinho = table.Column<int>(nullable: false),
                    Imagem = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vinhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vinhos_Regioes_IdRegiao",
                        column: x => x.IdRegiao,
                        principalTable: "Regioes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vinhos_TiposUva_IdTipoUva",
                        column: x => x.IdTipoUva,
                        principalTable: "TiposUva",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vinhos_TiposVinho_IdTipoVinho",
                        column: x => x.IdTipoVinho,
                        principalTable: "TiposVinho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vinhos_IdRegiao",
                table: "Vinhos",
                column: "IdRegiao");

            migrationBuilder.CreateIndex(
                name: "IX_Vinhos_IdTipoUva",
                table: "Vinhos",
                column: "IdTipoUva");

            migrationBuilder.CreateIndex(
                name: "IX_Vinhos_IdTipoVinho",
                table: "Vinhos",
                column: "IdTipoVinho");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vinhos");
        }
    }
}
