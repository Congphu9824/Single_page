﻿// <auto-generated />
using System;
using API.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(StaffDbContext))]
    [Migration("20241227085435_hi")]
    partial class hi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Model.Notes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StaffId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4178b3e7-72d1-43bc-b1c7-b8b4cfcc5af5"),
                            DateCreated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6626),
                            Text = "Welcome Note"
                        },
                        new
                        {
                            Id = new Guid("1e4739ac-b5c4-47bd-a41f-9b0eaa0eb06d"),
                            DateCreated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6628),
                            Text = "Take note"
                        });
                });

            modelBuilder.Entity("Data.Model.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("loacation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0fd42793-abd9-498c-babf-fef8dca8a0c1"),
                            DateCreated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6515),
                            DateDeleted = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6525),
                            DateOfBirth = new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6522),
                            FirstName = "John",
                            Gender = "Male",
                            LastName = "Doe",
                            NickName = "Johnny",
                            Place = "New York",
                            Position = "Developer",
                            Salary = 50000.0,
                            Status = "Active",
                            loacation = ""
                        },
                        new
                        {
                            Id = new Guid("85ccb8ee-aa51-4294-8b7d-bdfcc726c373"),
                            DateCreated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6540),
                            DateDeleted = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6540),
                            DateOfBirth = new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6540),
                            FirstName = "Jane",
                            Gender = "Female",
                            LastName = "Smith",
                            NickName = "Janey",
                            Place = "London",
                            Position = "Manager",
                            Salary = 60000.0,
                            Status = "Inactive",
                            loacation = ""
                        },
                        new
                        {
                            Id = new Guid("2b10409f-2710-48ac-a730-ac8c39e2f543"),
                            DateCreated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6543),
                            DateDeleted = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6543),
                            DateOfBirth = new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6543),
                            FirstName = "John",
                            Gender = "",
                            LastName = "Doe",
                            NickName = "Johnny",
                            Place = "New York",
                            Position = "Designer",
                            Salary = 55000.0,
                            Status = "Active",
                            loacation = ""
                        },
                        new
                        {
                            Id = new Guid("37c03f7f-1be7-4ab1-9442-33d976d78021"),
                            DateCreated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6552),
                            DateDeleted = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6553),
                            DateOfBirth = new DateTime(1987, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6553),
                            FirstName = "Alice",
                            Gender = "",
                            LastName = "Johnson",
                            NickName = "Ally",
                            Place = "Los Angeles",
                            Position = "tester",
                            Salary = 70000.0,
                            Status = "Active",
                            loacation = ""
                        },
                        new
                        {
                            Id = new Guid("9ba5e402-3ea3-450d-b287-6a98755075f8"),
                            DateCreated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6555),
                            DateDeleted = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6555),
                            DateOfBirth = new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6555),
                            FirstName = "Bob",
                            Gender = "",
                            LastName = "Brown",
                            NickName = "Bobby",
                            Place = "San Francisco",
                            Position = "Developer",
                            Salary = 65000.0,
                            Status = "Inactive",
                            loacation = ""
                        });
                });

            modelBuilder.Entity("Data.Model.Notes", b =>
                {
                    b.HasOne("Data.Model.Staff", "Staff")
                        .WithMany("notes")
                        .HasForeignKey("StaffId");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Data.Model.Staff", b =>
                {
                    b.Navigation("notes");
                });
#pragma warning restore 612, 618
        }
    }
}