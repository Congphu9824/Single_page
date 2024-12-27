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
    [Migration("20241227093443_hiii")]
    partial class hiii
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
                            Id = new Guid("4de23ef2-2adf-44a9-99d0-277514ea721d"),
                            DateCreated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2837),
                            Text = "Welcome Note"
                        },
                        new
                        {
                            Id = new Guid("bd459d05-c735-495d-8017-94d51c69599c"),
                            DateCreated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2845),
                            Text = "Take note"
                        });
                });

            modelBuilder.Entity("Data.Model.Staffs", b =>
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
                            Id = new Guid("77883fe1-a445-467f-b81d-c1531478777a"),
                            DateCreated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2722),
                            DateDeleted = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2734),
                            DateOfBirth = new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2731),
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
                            Id = new Guid("0db85d50-f604-46fc-9ee2-71766b6bf24a"),
                            DateCreated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2752),
                            DateDeleted = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2752),
                            DateOfBirth = new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2752),
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
                            Id = new Guid("ab1d47a1-7087-41e8-89f0-c24043e825eb"),
                            DateCreated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2755),
                            DateDeleted = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2755),
                            DateOfBirth = new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2755),
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
                            Id = new Guid("d0263cd5-f324-424e-b136-aed0754981e8"),
                            DateCreated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2757),
                            DateDeleted = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2758),
                            DateOfBirth = new DateTime(1987, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2757),
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
                            Id = new Guid("058f53b1-afbe-4f70-bc99-13aad3469aaa"),
                            DateCreated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2759),
                            DateDeleted = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2760),
                            DateOfBirth = new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2760),
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
                    b.HasOne("Data.Model.Staffs", "Staff")
                        .WithMany("notes")
                        .HasForeignKey("StaffId");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Data.Model.Staffs", b =>
                {
                    b.Navigation("notes");
                });
#pragma warning restore 612, 618
        }
    }
}