﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitOfWork;

namespace UnitOfWork.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200418144241_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UnitOfWork.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "J. K. Rowling",
                            CreateDate = new DateTime(2020, 4, 18, 14, 42, 40, 866, DateTimeKind.Utc).AddTicks(3324),
                            Title = "Harry Potter"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Miguel De Cervantes",
                            CreateDate = new DateTime(2020, 4, 18, 14, 42, 40, 866, DateTimeKind.Utc).AddTicks(4054),
                            Title = "Don Quixote"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Fyodor Dostoyevsky",
                            CreateDate = new DateTime(2020, 4, 18, 14, 42, 40, 866, DateTimeKind.Utc).AddTicks(4069),
                            Title = "Crime and Punishment"
                        });
                });

            modelBuilder.Entity("UnitOfWork.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2020, 4, 18, 14, 42, 40, 864, DateTimeKind.Utc).AddTicks(8894),
                            Name = "Library 1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
