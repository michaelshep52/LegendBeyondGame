﻿// <auto-generated />
using Legend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Legend.Data.Migrations
{
    [DbContext(typeof(LegendContext))]
    [Migration("20230307154838_RelationshipsRemoved")]
    partial class RelationshipsRemoved
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Legend.Domain.Entities.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CharacterId"));

                    b.Property<int>("Health")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Speed")
                        .HasColumnType("integer");

                    b.Property<int>("Stamina")
                        .HasColumnType("integer");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Legend.Domain.Entities.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MissionId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("MissionId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("Legend.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
