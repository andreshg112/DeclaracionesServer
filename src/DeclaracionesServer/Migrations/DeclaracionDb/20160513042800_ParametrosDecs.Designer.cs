using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using DeclaracionesServer.Models;

namespace DeclaracionesServer.Migrations.DeclaracionDb
{
    [DbContext(typeof(DeclaracionDbContext))]
    [Migration("20160513042800_ParametrosDecs")]
    partial class ParametrosDecs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("DeclaracionesServer.Models.Declaracion", b =>
                {
                    b.Property<int>("DeclaracionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("anio");

                    b.Property<string>("calidad_declarante");

                    b.Property<DateTime>("correccion_fecha");

                    b.Property<string>("correccion_id");

                    b.Property<bool>("correccion_valor");

                    b.Property<string>("departamento");

                    b.Property<string>("direccion");

                    b.Property<string>("dv");

                    b.Property<string>("entidad_codigo_dane");

                    b.Property<string>("entidad_departamento");

                    b.Property<string>("entidad_dv");

                    b.Property<string>("entidad_nit");

                    b.Property<string>("mes");

                    b.Property<string>("municipio");

                    b.Property<string>("nombres");

                    b.Property<string>("numero_documento")
                        .IsRequired();

                    b.Property<string>("telefono");

                    b.Property<string>("tipo_documento");

                    b.HasKey("DeclaracionId");
                });
        }
    }
}
