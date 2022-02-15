using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCoreRest.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frutas",
                columns: table => new
                {
                    IdFruta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreFruta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PesoFruta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frutas", x => x.IdFruta);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frutas");
        }
    }
}
