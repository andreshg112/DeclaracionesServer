using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using DeclaracionesServer.Models;

namespace DeclaracionesServer.Migrations.DeclaracionDb
{
    [DbContext(typeof(DeclaracionDbContext))]
    partial class DeclaracionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("DeclaracionesServer.Models.Gasolina", b =>
                {
                    b.Property<int>("GasolinaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DeclaracionId");

                    b.Property<float>("base_gravable");

                    b.Property<string>("clase");

                    b.Property<float>("galones_gravado");

                    b.Property<float>("porcentaje_alcohol");

                    b.Property<float>("precio_referencia");

                    b.Property<float>("sobretasa");

                    b.HasKey("GasolinaId");
                });

            modelBuilder.Entity("DeclaracionesServer.Models.Gasolina", b =>
                {
                    b.HasOne("DeclaracionesServer.Models.Declaracion")
                        .WithMany()
                        .HasForeignKey("DeclaracionId");
                });
        }
    }
}
