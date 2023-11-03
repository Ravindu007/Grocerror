﻿// <auto-generated />
using System;
using Grocerror.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Grocerror.DataAccess.Migrations
{
    [DbContext(typeof(ItemDBContext))]
    [Migration("20231103131711_newData")]
    partial class newData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Grocerror.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ListId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 11, 3, 18, 47, 10, 767, DateTimeKind.Local).AddTicks(5719),
                            ItemName = "Milk from DB",
                            ListId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 11, 3, 18, 47, 10, 767, DateTimeKind.Local).AddTicks(5740),
                            ItemName = "Coffeee new from DB",
                            ListId = 2,
                            Status = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}