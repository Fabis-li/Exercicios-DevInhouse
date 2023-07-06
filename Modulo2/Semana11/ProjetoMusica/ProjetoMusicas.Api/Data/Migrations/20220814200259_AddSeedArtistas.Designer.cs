﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoMusicas.Api.Data;

#nullable disable

namespace ProjetoMusicas.Api.Data.Migrations
{
    [DbContext(typeof(ProjetoDbContext))]
    [Migration("20220814200259_AddSeedArtistas")]
    partial class AddSeedArtistas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoMusicas.Api.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnoLancamento")
                        .HasColumnType("int");

                    b.Property<int>("ArtistaId")
                        .HasColumnType("int");

                    b.Property<string>("CapaUrl")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistaId");

                    b.ToTable("Albuns", (string)null);
                });

            modelBuilder.Entity("ProjetoMusicas.Api.Models.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FotoUrl")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("NomeArtistico")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Artistas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Michael Jackson",
                            NomeArtistico = "Michael Jackson"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Elvis Presley",
                            NomeArtistico = "Elvis Presley"
                        });
                });

            modelBuilder.Entity("ProjetoMusicas.Api.Models.Musica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("ArtistaId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duracao")
                        .HasColumnType("time");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("ArtistaId");

                    b.ToTable("Musicas", (string)null);
                });

            modelBuilder.Entity("ProjetoMusicas.Api.Models.Album", b =>
                {
                    b.HasOne("ProjetoMusicas.Api.Models.Artista", "Artista")
                        .WithMany("Albuns")
                        .HasForeignKey("ArtistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");
                });

            modelBuilder.Entity("ProjetoMusicas.Api.Models.Musica", b =>
                {
                    b.HasOne("ProjetoMusicas.Api.Models.Album", "Album")
                        .WithMany("Musicas")
                        .HasForeignKey("AlbumId");

                    b.HasOne("ProjetoMusicas.Api.Models.Artista", "Artista")
                        .WithMany("Musicas")
                        .HasForeignKey("ArtistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Artista");
                });

            modelBuilder.Entity("ProjetoMusicas.Api.Models.Album", b =>
                {
                    b.Navigation("Musicas");
                });

            modelBuilder.Entity("ProjetoMusicas.Api.Models.Artista", b =>
                {
                    b.Navigation("Albuns");

                    b.Navigation("Musicas");
                });
#pragma warning restore 612, 618
        }
    }
}