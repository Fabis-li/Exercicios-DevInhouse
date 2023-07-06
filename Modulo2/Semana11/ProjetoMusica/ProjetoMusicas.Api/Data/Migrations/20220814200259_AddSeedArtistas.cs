using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoMusicas.Api.Data.Migrations
{
    public partial class AddSeedArtistas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artistas",
                columns: new[] { "Id", "FotoUrl", "Nome", "NomeArtistico" },
                values: new object[] { 1, null, "Michael Jackson", "Michael Jackson" });

            migrationBuilder.InsertData(
                table: "Artistas",
                columns: new[] { "Id", "FotoUrl", "Nome", "NomeArtistico" },
                values: new object[] { 2, null, "Elvis Presley", "Elvis Presley" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
