using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea5.Migrations
{
    /// <inheritdoc />
    public partial class BaseDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlataformaContext",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlataformaContext", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoJuegoContext",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Desarrollador = table.Column<string>(type: "TEXT", nullable: false),
                    Plataforma = table.Column<string>(type: "TEXT", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false),
                    FechaLanzamiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ImagenPortada = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoJuegoContext", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonajeContext",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Alias = table.Column<string>(type: "TEXT", nullable: false),
                    Rol = table.Column<string>(type: "TEXT", nullable: false),
                    Habilidad = table.Column<string>(type: "TEXT", nullable: false),
                    Arma = table.Column<string>(type: "TEXT", nullable: false),
                    NivelPoder = table.Column<int>(type: "INTEGER", nullable: false),
                    ImagenPortada = table.Column<string>(type: "TEXT", nullable: false),
                    VideoJuegoId = table.Column<int>(type: "INTEGER", nullable: false),
                    VideoJuegosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajeContext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonajeContext_VideoJuegoContext_VideoJuegosId",
                        column: x => x.VideoJuegosId,
                        principalTable: "VideoJuegoContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonajeContext_VideoJuegosId",
                table: "PersonajeContext",
                column: "VideoJuegosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonajeContext");

            migrationBuilder.DropTable(
                name: "PlataformaContext");

            migrationBuilder.DropTable(
                name: "VideoJuegoContext");
        }
    }
}
