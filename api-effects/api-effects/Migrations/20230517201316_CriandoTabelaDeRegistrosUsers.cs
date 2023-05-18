using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_effects.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaDeRegistrosUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroSerie",
                table: "Registros");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroSerie",
                table: "Registros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
