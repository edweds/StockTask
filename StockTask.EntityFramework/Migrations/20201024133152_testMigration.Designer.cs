﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockTask.EntityFramework;

namespace StockTask.EntityFramework.Migrations
{
    [DbContext(typeof(StockTaskDbContext))]
    [Migration("20201024133152_testMigration")]
    partial class testMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockTask.Domain.Models.CreatedItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReceivingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CreatedItems");
                });

            modelBuilder.Entity("StockTask.Domain.Models.SoldItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SoldDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SoldItems");
                });

            modelBuilder.Entity("StockTask.Domain.Models.ToStockItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ToStockTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ToStockItems");
                });
#pragma warning restore 612, 618
        }
    }
}
