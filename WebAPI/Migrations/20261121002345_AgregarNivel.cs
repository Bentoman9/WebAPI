using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AgregarNivel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NivelId",
                table: "Curso",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Nivel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_NivelId",
                table: "Curso",
                column: "NivelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Nivel_NivelId",
                table: "Curso",
                column: "NivelId",
                principalTable: "Nivel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Nivel_NivelId",
                table: "Curso");

            migrationBuilder.DropTable(
                name: "Nivel");

            migrationBuilder.DropIndex(
                name: "IX_Curso_NivelId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "NivelId",
                table: "Curso");
        }
    }
}
