using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorMotosRetenidas.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Infractores",
                columns: table => new
                {
                    DniInfractor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreInfractor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoInfractor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infractores", x => x.DniInfractor);
                });

            migrationBuilder.CreateTable(
                name: "Titulares",
                columns: table => new
                {
                    DniTitular = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTitular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoTitular = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titulares", x => x.DniTitular);
                });

            migrationBuilder.CreateTable(
                name: "Motos",
                columns: table => new
                {
                    NroRetencion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRetencion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotivoRetencion = table.Column<int>(type: "int", nullable: false),
                    EstadoMoto = table.Column<int>(type: "int", nullable: false),
                    DniTitular = table.Column<int>(type: "int", nullable: false),
                    DniInfractor = table.Column<int>(type: "int", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motos", x => x.NroRetencion);
                    table.ForeignKey(
                        name: "FK_Motos_Infractores_DniInfractor",
                        column: x => x.DniInfractor,
                        principalTable: "Infractores",
                        principalColumn: "DniInfractor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motos_Titulares_DniTitular",
                        column: x => x.DniTitular,
                        principalTable: "Titulares",
                        principalColumn: "DniTitular",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motos_DniInfractor",
                table: "Motos",
                column: "DniInfractor");

            migrationBuilder.CreateIndex(
                name: "IX_Motos_DniTitular",
                table: "Motos",
                column: "DniTitular");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motos");

            migrationBuilder.DropTable(
                name: "Infractores");

            migrationBuilder.DropTable(
                name: "Titulares");
        }
    }
}
