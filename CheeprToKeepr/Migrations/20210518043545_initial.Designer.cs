﻿// <auto-generated />
using System;
using CheeprToKeepr.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CheeprToKeepr.Migrations
{
    [DbContext(typeof(CheeprToKeeprContext))]
    [Migration("20210518043545_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CheeprToKeepr.Models.Expense", b =>
                {
                    b.Property<int>("ExpenseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpenseCategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpenseDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("VehicleID")
                        .HasColumnType("int");

                    b.HasKey("ExpenseID");

                    b.HasIndex("ExpenseCategoryID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.ExpenseCategory", b =>
                {
                    b.Property<int>("ExpenseCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExpenseType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ExpenseCategoryID");

                    b.ToTable("ExpenseCategory");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Fillup", b =>
                {
                    b.Property<int>("FillupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Gallons")
                        .HasColumnType("float");

                    b.Property<double>("MilesDriven")
                        .HasColumnType("float");

                    b.Property<int>("VehicleID")
                        .HasColumnType("int");

                    b.HasKey("FillupID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Fillup");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ServiceCategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ServiceDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleID")
                        .HasColumnType("int");

                    b.Property<int?>("VehicleMilesAtService")
                        .HasColumnType("int");

                    b.Property<int>("VendorID")
                        .HasColumnType("int");

                    b.HasKey("ServiceID");

                    b.HasIndex("ServiceCategoryID");

                    b.HasIndex("VehicleID");

                    b.HasIndex("VendorID");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.ServiceCategory", b =>
                {
                    b.Property<int>("ServiceCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ServiceCategoryID");

                    b.ToTable("ServiceCategory");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MakeName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal>("MilesPerGallon")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ModelName1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModelName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TireMileage")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("VehicleMileage")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("VehicleID");

                    b.HasIndex("UserID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Vendor", b =>
                {
                    b.Property<int>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int>("VendorCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorID");

                    b.HasIndex("VendorCategoryID");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.VendorCategory", b =>
                {
                    b.Property<int>("VendorCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VendorType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("VendorCategoryID");

                    b.ToTable("VendorCategory");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Expense", b =>
                {
                    b.HasOne("CheeprToKeepr.Models.ExpenseCategory", "ExpenseCategory")
                        .WithMany("Expenses")
                        .HasForeignKey("ExpenseCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CheeprToKeepr.Models.Vehicle", "Vehicle")
                        .WithMany("Expenses")
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpenseCategory");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Fillup", b =>
                {
                    b.HasOne("CheeprToKeepr.Models.Vehicle", "Vehicle")
                        .WithMany("Fillups")
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Service", b =>
                {
                    b.HasOne("CheeprToKeepr.Models.ServiceCategory", "ServiceCategory")
                        .WithMany("Services")
                        .HasForeignKey("ServiceCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CheeprToKeepr.Models.Vehicle", "Vehicle")
                        .WithMany("Services")
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CheeprToKeepr.Models.Vendor", "Vendor")
                        .WithMany("Services")
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceCategory");

                    b.Navigation("Vehicle");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Vehicle", b =>
                {
                    b.HasOne("CheeprToKeepr.Models.User", "User")
                        .WithMany("Vehicles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Vendor", b =>
                {
                    b.HasOne("CheeprToKeepr.Models.VendorCategory", "VendorCategory")
                        .WithMany("Vendors")
                        .HasForeignKey("VendorCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VendorCategory");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.ExpenseCategory", b =>
                {
                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.ServiceCategory", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.User", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Vehicle", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("Fillups");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.Vendor", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("CheeprToKeepr.Models.VendorCategory", b =>
                {
                    b.Navigation("Vendors");
                });
#pragma warning restore 612, 618
        }
    }
}