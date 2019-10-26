﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication.Data;

namespace WebApplication.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication.Data.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BodyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Doors")
                        .HasColumnType("int");

                    b.Property<string>("Engine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MakerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Wheels")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MakerId");

                    b.HasIndex("ModelId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("WebApplication.Data.Entities.Maker", b =>
                {
                    b.Property<Guid>("MakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MakerId");

                    b.ToTable("Makers");
                });

            modelBuilder.Entity("WebApplication.Data.Entities.Model", b =>
                {
                    b.Property<Guid>("ModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MakerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelId");

                    b.HasIndex("MakerId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("WebApplication.Data.Entities.Motorbike", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Engine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MakerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Wheels")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MakerId");

                    b.HasIndex("ModelId");

                    b.ToTable("Motorbikes");
                });

            modelBuilder.Entity("WebApplication.Data.Entities.Car", b =>
                {
                    b.HasOne("WebApplication.Data.Entities.Maker", "Make")
                        .WithMany()
                        .HasForeignKey("MakerId");

                    b.HasOne("WebApplication.Data.Entities.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");
                });

            modelBuilder.Entity("WebApplication.Data.Entities.Model", b =>
                {
                    b.HasOne("WebApplication.Data.Entities.Maker", "Maker")
                        .WithMany()
                        .HasForeignKey("MakerId");
                });

            modelBuilder.Entity("WebApplication.Data.Entities.Motorbike", b =>
                {
                    b.HasOne("WebApplication.Data.Entities.Maker", "Make")
                        .WithMany()
                        .HasForeignKey("MakerId");

                    b.HasOne("WebApplication.Data.Entities.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");
                });
#pragma warning restore 612, 618
        }
    }
}
