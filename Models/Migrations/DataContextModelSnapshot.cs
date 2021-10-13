﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Models.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("ImageSrc")
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

            modelBuilder.Entity("Models.Entity.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Domicile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistryDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = new Guid("91f48386-51fa-4f88-8f24-29c6b4170e0e"),
                            AccName = "Taikhoan1",
                            Address = "Hưng Yên - Việt Nam",
                            DateOfBirth = new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(2660),
                            Domicile = "Việt nam",
                            Email = "Email.NguoiDung@mail.mail",
                            Name = "Người dùng 1",
                            PhoneNumber = "0987654321",
                            RegistryDate = new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8194)
                        },
                        new
                        {
                            ID = new Guid("e268e9dc-8e39-40c7-b9f0-f6b78e99180d"),
                            AccName = "Taikhoan2",
                            Address = "Hưng Yên - Việt Nam",
                            DateOfBirth = new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8923),
                            Domicile = "Việt nam",
                            Email = "Email.NguoiDung@mail.mail",
                            Name = "Người dùng 2",
                            PhoneNumber = "0987654321",
                            RegistryDate = new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8934)
                        },
                        new
                        {
                            ID = new Guid("67f27ccd-066a-4e0d-8129-fcf55ee29d40"),
                            AccName = "Taikhoan3",
                            Address = "Hưng Yên - Việt Nam",
                            DateOfBirth = new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8941),
                            Domicile = "Việt nam",
                            Email = "Email.NguoiDung@mail.mail",
                            Name = "Người dùng 3",
                            PhoneNumber = "0987654321",
                            RegistryDate = new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8943)
                        },
                        new
                        {
                            ID = new Guid("6f0f20eb-7bc2-4216-aba4-357413f6ac3a"),
                            AccName = "Taikhoan4",
                            Address = "Hưng Yên - Việt Nam",
                            DateOfBirth = new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8948),
                            Domicile = "Việt nam",
                            Email = "Email.NguoiDung@mail.mail",
                            Name = "Người dùng 4",
                            PhoneNumber = "0987654321",
                            RegistryDate = new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8949)
                        },
                        new
                        {
                            ID = new Guid("31eb339f-d31f-4f01-b3d2-9c3ca8de3499"),
                            AccName = "Taikhoan5",
                            Address = "Hưng Yên - Việt Nam",
                            DateOfBirth = new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8955),
                            Domicile = "Việt nam",
                            Email = "Email.NguoiDung@mail.mail",
                            Name = "Người dùng 5",
                            PhoneNumber = "0987654321",
                            RegistryDate = new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8956)
                        },
                        new
                        {
                            ID = new Guid("ecf5cfd5-e82a-4a2e-b2e7-92d4f5ea074b"),
                            AccName = "Taikhoan6",
                            Address = "Hưng Yên - Việt Nam",
                            DateOfBirth = new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8961),
                            Domicile = "Việt nam",
                            Email = "Email.NguoiDung@mail.mail",
                            Name = "Người dùng 6",
                            PhoneNumber = "0987654321",
                            RegistryDate = new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8963)
                        },
                        new
                        {
                            ID = new Guid("4916d35b-1d58-415b-986c-bd2aeb5a61c4"),
                            AccName = "Taikhoan7",
                            Address = "Hưng Yên - Việt Nam",
                            DateOfBirth = new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(9058),
                            Domicile = "Việt nam",
                            Email = "Email.NguoiDung@mail.mail",
                            Name = "Người dùng 7",
                            PhoneNumber = "0987654321",
                            RegistryDate = new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(9060)
                        });
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
