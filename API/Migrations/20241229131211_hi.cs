using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class hi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loacation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "DateCreated", "StaffId", "Text" },
                values: new object[,]
                {
                    { new Guid("29ce6ef4-7b11-4fe1-b252-ed67f8ddfb75"), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(2092), null, "Take note" },
                    { new Guid("5512791e-3f36-40a7-99ac-a4f58794ae56"), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(2090), null, "Welcome Note" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateOfBirth", "DateUpdated", "FirstName", "Gender", "LastName", "NickName", "Place", "Position", "Salary", "Status", "loacation" },
                values: new object[,]
                {
                    { new Guid("46ea3448-7dc9-49b5-81b2-0e6cd155c93c"), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1817), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1817), new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1817), "Jane", "Female", "Smith", "Janey", "London", "Manager", 60000.0, "Inactive", "" },
                    { new Guid("5a898d4a-dd98-4eca-abd6-626db58a1ba4"), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1841), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1842), new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1842), "Bob", "", "Brown", "Bobby", "San Francisco", "Developer", 65000.0, "Inactive", "" },
                    { new Guid("c4d5b576-083c-4195-82b1-186e818cbc42"), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1821), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1822), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1822), "John", "", "Doe", "Johnny", "New York", "Designer", 55000.0, "Active", "" },
                    { new Guid("d1e1cced-fb23-4883-8f73-beb4562f1b77"), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1751), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1769), new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1765), "John", "Male", "Doe", "Johnny", "New York", "Developer", 50000.0, "Active", "" },
                    { new Guid("efcca54e-3103-4dcd-a0be-4ef927435384"), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1838), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1838), new DateTime(1987, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 20, 12, 10, 924, DateTimeKind.Local).AddTicks(1838), "Alice", "", "Johnson", "Ally", "Los Angeles", "tester", 70000.0, "Active", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_StaffId",
                table: "Notes",
                column: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
