using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace DeclaracionesServer.Migrations.DeclaracionDb
{
    public partial class AddGasolina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gasolina",
                columns: table => new
                {
                    GasolinaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeclaracionId = table.Column<int>(nullable: false),
                    base_gravable = table.Column<float>(nullable: false),
                    clase = table.Column<string>(nullable: true),
                    galones_gravado = table.Column<float>(nullable: false),
                    porcentaje_alcohol = table.Column<float>(nullable: false),
                    precio_referencia = table.Column<float>(nullable: false),
                    sobretasa = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gasolina", x => x.GasolinaId);
                    table.ForeignKey(
                        name: "FK_Gasolina_Declaracion_DeclaracionId",
                        column: x => x.DeclaracionId,
                        principalTable: "Declaracion",
                        principalColumn: "DeclaracionId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Gasolina");
        }
    }
}
