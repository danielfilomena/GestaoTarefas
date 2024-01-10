using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitDataTableUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql($@"
                INSERT INTO Usuario(nome) VALUES('Usuario 1');
                INSERT INTO Usuario(nome) VALUES('Usuario 2');
                INSERT INTO Usuario(nome) VALUES('Usuario 3');
            ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
