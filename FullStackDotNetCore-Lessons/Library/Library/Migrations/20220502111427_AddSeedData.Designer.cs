﻿// <auto-generated />
using System;
using Library.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220502111427_AddSeedData")]
    partial class AddSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 5, 2, 14, 14, 26, 712, DateTimeKind.Local).AddTicks(5538),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "$2a$11$.2TvPcavmSVfcZH5EnrcNeSmFTtDs/TQ5byl3Y9BorDR/CeLy9aD.",
                            Role = 1,
                            Status = 1,
                            UserName = "administrator"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 5, 2, 14, 14, 26, 718, DateTimeKind.Local).AddTicks(5537),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "$2a$11$vH0xOzPUOjuh6xr7xR/ROugB5UcHJ5PbKMc82O4AhZ0tdbZeJRE.m",
                            Role = 2,
                            Status = 1,
                            UserName = "firat"
                        });
                });

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Isim");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Soyisim");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageCount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookTypeId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library.Models.BookType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("Library.Models.Operation", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("Operasyonlar");
                });

            modelBuilder.Entity("Library.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDay = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 5, 2, 14, 14, 26, 720, DateTimeKind.Local).AddTicks(6238),
                            FirstName = "Fırat",
                            Gender = 0,
                            LastName = "Alçın",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthDay = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 5, 2, 14, 14, 26, 720, DateTimeKind.Local).AddTicks(8378),
                            FirstName = "Enes",
                            Gender = 0,
                            LastName = "Çiçek",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            BirthDay = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 5, 2, 14, 14, 26, 720, DateTimeKind.Local).AddTicks(8392),
                            FirstName = "Sibel",
                            Gender = 1,
                            LastName = "Doruk",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            BirthDay = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 5, 2, 14, 14, 26, 720, DateTimeKind.Local).AddTicks(8395),
                            FirstName = "Hatice",
                            Gender = 1,
                            LastName = "Akkoçan",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        });
                });

            modelBuilder.Entity("Library.Models.StudentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDay = new DateTime(1998, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 5, 2, 14, 14, 26, 720, DateTimeKind.Local).AddTicks(9456),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolNumber = "100",
                            Status = 1,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthDay = new DateTime(1998, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 5, 2, 14, 14, 26, 721, DateTimeKind.Local).AddTicks(977),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolNumber = "101",
                            Status = 1,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            BirthDay = new DateTime(1998, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 5, 2, 14, 14, 26, 721, DateTimeKind.Local).AddTicks(986),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolNumber = "102",
                            Status = 1,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 4,
                            BirthDay = new DateTime(1998, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 5, 2, 14, 14, 26, 721, DateTimeKind.Local).AddTicks(988),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolNumber = "103",
                            Status = 1,
                            StudentId = 4
                        });
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.HasOne("Library.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Models.BookType", "BookType")
                        .WithMany("Books")
                        .HasForeignKey("BookTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("BookType");
                });

            modelBuilder.Entity("Library.Models.Operation", b =>
                {
                    b.HasOne("Library.Models.Book", "Book")
                        .WithMany("Operations")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Models.Student", "Student")
                        .WithMany("Operations")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Library.Models.StudentDetail", b =>
                {
                    b.HasOne("Library.Models.Student", "Student")
                        .WithOne("StudentDetail")
                        .HasForeignKey("Library.Models.StudentDetail", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Navigation("Operations");
                });

            modelBuilder.Entity("Library.Models.BookType", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Models.Student", b =>
                {
                    b.Navigation("Operations");

                    b.Navigation("StudentDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
