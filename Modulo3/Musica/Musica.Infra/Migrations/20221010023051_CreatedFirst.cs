using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musica.Infra.Migrations
{
    public partial class CreatedFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MUSICAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    NOME_MUSICA = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    SEQUENCIA_MUSICA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUSICAS", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MUSICAS");
        }
    }
}
