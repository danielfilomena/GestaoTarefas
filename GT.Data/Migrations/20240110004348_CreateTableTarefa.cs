using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableTarefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefa",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<int>(type: "INT", nullable: false),
                    prioridade = table.Column<int>(type: "INT", nullable: false),
                    titulo = table.Column<string>(type: "varChar(50)", nullable: false),
                    descricao = table.Column<string>(type: "varChar(200)", nullable: false),
                    dataCadastro = table.Column<DateTime>(type: "DateTime", nullable: false),
                    dataConclusao = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefa_id", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tarefa_Usuario_id",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IDX_Tarefa_usuarioId",
                table: "Tarefa",
                column: "usuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefa");
        }
    }
}
