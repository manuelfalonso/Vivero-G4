﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vivero_G4.Context;

namespace Vivero_G4.Migrations
{
    [DbContext(typeof(ViveroContext))]
    partial class ViveroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vivero_G4.Models.Articulo", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("ViveroId")
                        .HasColumnType("int");

                    b.HasKey("ArticuloId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("ViveroId");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("Vivero_G4.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Vivero_G4.Models.Comentario", b =>
                {
                    b.Property<int>("ComentarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContenidoId")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComentarioId");

                    b.HasIndex("ContenidoId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Vivero_G4.Models.Contenido", b =>
                {
                    b.Property<int>("ContenidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlogId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContenidoId");

                    b.HasIndex("BlogId");

                    b.ToTable("Contenidos");
                });

            modelBuilder.Entity("Vivero_G4.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ViveroId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.HasIndex("ViveroId");

                    b.ToTable("Usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("Vivero_G4.Models.Venta", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("CodSeguridad")
                        .HasColumnType("int");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FecVencimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NroTarjeta")
                        .HasColumnType("bigint");

                    b.Property<int>("TipoEntrega")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("ViveroId")
                        .HasColumnType("int");

                    b.HasKey("VentaId");

                    b.HasIndex("ViveroId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Vivero_G4.Models.Vivero", b =>
                {
                    b.Property<int>("ViveroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ViveroId");

                    b.HasIndex("BlogId");

                    b.ToTable("Viveros");
                });

            modelBuilder.Entity("Vivero_G4.Models.Administrador", b =>
                {
                    b.HasBaseType("Vivero_G4.Models.Usuario");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("Vivero_G4.Models.Cliente", b =>
                {
                    b.HasBaseType("Vivero_G4.Models.Usuario");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("Vivero_G4.Models.Articulo", b =>
                {
                    b.HasOne("Vivero_G4.Models.Usuario", null)
                        .WithMany("ArticulosFavoritos")
                        .HasForeignKey("UsuarioId");

                    b.HasOne("Vivero_G4.Models.Vivero", null)
                        .WithMany("Stock")
                        .HasForeignKey("ViveroId");
                });

            modelBuilder.Entity("Vivero_G4.Models.Comentario", b =>
                {
                    b.HasOne("Vivero_G4.Models.Contenido", null)
                        .WithMany("Comentarios")
                        .HasForeignKey("ContenidoId");
                });

            modelBuilder.Entity("Vivero_G4.Models.Contenido", b =>
                {
                    b.HasOne("Vivero_G4.Models.Blog", null)
                        .WithMany("Contenidos")
                        .HasForeignKey("BlogId");
                });

            modelBuilder.Entity("Vivero_G4.Models.Usuario", b =>
                {
                    b.HasOne("Vivero_G4.Models.Vivero", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("ViveroId");
                });

            modelBuilder.Entity("Vivero_G4.Models.Venta", b =>
                {
                    b.HasOne("Vivero_G4.Models.Vivero", null)
                        .WithMany("Ventas")
                        .HasForeignKey("ViveroId");
                });

            modelBuilder.Entity("Vivero_G4.Models.Vivero", b =>
                {
                    b.HasOne("Vivero_G4.Models.Blog", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogId");
                });
#pragma warning restore 612, 618
        }
    }
}
