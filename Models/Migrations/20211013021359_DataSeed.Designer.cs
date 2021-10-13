﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Models.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211013021359_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.CanBo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CanBos");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Hưng Yên - Việt Nam",
                            Name = "Cán bộ 1",
                            PhoneNumber = "0987654321"
                        },
                        new
                        {
                            ID = 2,
                            Address = "Hưng Yên - Việt Nam",
                            Name = "Cán bộ 2",
                            PhoneNumber = "0987654321"
                        },
                        new
                        {
                            ID = 3,
                            Address = "Hưng Yên - Việt Nam",
                            Name = "Cán bộ 3",
                            PhoneNumber = "0987654321"
                        },
                        new
                        {
                            ID = 4,
                            Address = "Hưng Yên - Việt Nam",
                            Name = "Cán bộ 4",
                            PhoneNumber = "0987654321"
                        },
                        new
                        {
                            ID = 5,
                            Address = "Hưng Yên - Việt Nam",
                            Name = "Cán bộ 5",
                            PhoneNumber = "0987654321"
                        });
                });

            modelBuilder.Entity("Models.Entity.Article", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("TypeID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Models.Entity.ArticleType", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ArticleTypes");
                });

            modelBuilder.Entity("Models.Entity.Article", b =>
                {
                    b.HasOne("Models.Entity.ArticleType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}