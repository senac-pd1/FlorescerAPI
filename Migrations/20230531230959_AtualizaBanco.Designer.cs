﻿// <auto-generated />
using System;
using FlorescerAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FlorescerAPI.Migrations
{
    [DbContext(typeof(MinimalContextDb))]
    [Migration("20230531230959_AtualizaBanco")]
    partial class AtualizaBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FlorescerAPI.Models.Planta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Climate")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Growth")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Irrigation")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Luminosity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Plantas", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
