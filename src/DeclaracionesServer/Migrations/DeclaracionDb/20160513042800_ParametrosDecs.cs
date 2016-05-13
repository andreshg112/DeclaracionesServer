using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace DeclaracionesServer.Migrations.DeclaracionDb
{
    public partial class ParametrosDecs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Declaracion",
                columns: table => new
                {
                    DeclaracionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    anio = table.Column<int>(nullable: false),
                    calidad_declarante = table.Column<string>(nullable: true),
                    correccion_fecha = table.Column<DateTime>(nullable: false),
                    correccion_id = table.Column<string>(nullable: true),
                    correccion_valor = table.Column<bool>(nullable: false),
                    departamento = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    dv = table.Column<string>(nullable: true),
                    entidad_codigo_dane = table.Column<string>(nullable: true),
                    entidad_departamento = table.Column<string>(nullable: true),
                    entidad_dv = table.Column<string>(nullable: true),
                    entidad_nit = table.Column<string>(nullable: true),
                    mes = table.Column<string>(nullable: true),
                    municipio = table.Column<string>(nullable: true),
                    nombres = table.Column<string>(nullable: true),
                    numero_documento = table.Column<string>(nullable: false),
                    telefono = table.Column<string>(nullable: true),
                    tipo_documento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Declaracion", x => x.DeclaracionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Declaracion");
        }
    }
}
