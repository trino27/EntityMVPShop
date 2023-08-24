﻿// <auto-generated />
using System;
using CyberHW1_5.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CyberHW1_5.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230807204002_RemoveAlterKeyfromUser")]
    partial class RemoveAlterKeyfromUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CyberHW1_5.Database.Entities.Error", b =>
                {
                    b.Property<int>("ErrorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ErrorId"));

                    b.Property<string>("Message")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Undefined message");

                    b.Property<string>("Request")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Undefined request");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("ErrorId");

                    b.HasIndex("ErrorId")
                        .IsUnique();

                    b.ToTable("errors");
                });

            modelBuilder.Entity("CyberHW1_5.Database.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("number")
                        .HasColumnType("bigint");

                    b.Property<string>("password")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("00000000");

                    b.Property<string>("phone")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasDefaultValue("000000000000");

                    b.HasKey("UserId");

                    b.HasIndex("login")
                        .IsUnique();

                    b.HasIndex("number")
                        .IsUnique();

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
