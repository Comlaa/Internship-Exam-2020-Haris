﻿// <auto-generated />
using System;
using InfinityMeshTest.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InfinityMeshTest.Dal.Migrations
{
    [DbContext(typeof(IMDbContext))]
    [Migration("20201109094625_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InfinityMeshTest.Dal.Domain.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PublishedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("InfinityMeshTest.Dal.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ViewProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ViewProfileId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 21,
                            Birthdate = new DateTime(1999, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 11, 9, 10, 41, 0, 0, DateTimeKind.Utc),
                            Email = "haris.mlaco@edu.fit.ba",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Haris Mlaco"
                        },
                        new
                        {
                            Id = 2,
                            Age = 31,
                            Birthdate = new DateTime(1989, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 11, 9, 10, 42, 0, 0, DateTimeKind.Utc),
                            Email = "admirmujkic@infinitymesh.com",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admir Mujkic"
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            Birthdate = new DateTime(1999, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 11, 9, 10, 43, 0, 0, DateTimeKind.Utc),
                            Email = "johndoe@doeCompany.com",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Doe"
                        });
                });

            modelBuilder.Entity("InfinityMeshTest.Dal.Domain.Blog", b =>
                {
                    b.HasOne("InfinityMeshTest.Dal.Domain.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InfinityMeshTest.Dal.Domain.User", b =>
                {
                    b.HasOne("InfinityMeshTest.Dal.Domain.User", "ViewProfile")
                        .WithMany()
                        .HasForeignKey("ViewProfileId");
                });
#pragma warning restore 612, 618
        }
    }
}
