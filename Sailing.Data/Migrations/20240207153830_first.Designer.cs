﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sailing.Data;

#nullable disable

namespace Sailing.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240207153830_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SAILING_BEACH.Boat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AfterSunset")
                        .HasColumnType("bit");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPassenger")
                        .HasColumnType("int");

                    b.Property<string>("YearOfManufacture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Boats");
                });

            modelBuilder.Entity("SAILING_BEACH.BoatDriver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("Seniority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BoatDrivers");
                });

            modelBuilder.Entity("SAILING_BEACH.SailingTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BoatDriverId")
                        .HasColumnType("int");

                    b.Property<int>("BoatId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BoatDriverId");

                    b.HasIndex("BoatId");

                    b.ToTable("SailingTime");
                });

            modelBuilder.Entity("SAILING_BEACH.SailingTime", b =>
                {
                    b.HasOne("SAILING_BEACH.BoatDriver", "BoatDriver")
                        .WithMany()
                        .HasForeignKey("BoatDriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SAILING_BEACH.Boat", "Boat")
                        .WithMany()
                        .HasForeignKey("BoatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boat");

                    b.Navigation("BoatDriver");
                });
#pragma warning restore 612, 618
        }
    }
}
