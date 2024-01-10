using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "VarChar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario_Id", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
