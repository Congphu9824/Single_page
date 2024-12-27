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
                    { new Guid("1e4739ac-b5c4-47bd-a41f-9b0eaa0eb06d"), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6628), null, "Take note" },
                    { new Guid("4178b3e7-72d1-43bc-b1c7-b8b4cfcc5af5"), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6626), null, "Welcome Note" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateOfBirth", "DateUpdated", "FirstName", "Gender", "LastName", "NickName", "Place", "Position", "Salary", "Status", "loacation" },
                values: new object[,]
                {
                    { new Guid("0fd42793-abd9-498c-babf-fef8dca8a0c1"), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6515), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6525), new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6522), "John", "Male", "Doe", "Johnny", "New York", "Developer", 50000.0, "Active", "" },
                    { new Guid("2b10409f-2710-48ac-a730-ac8c39e2f543"), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6543), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6543), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6543), "John", "", "Doe", "Johnny", "New York", "Designer", 55000.0, "Active", "" },
                    { new Guid("37c03f7f-1be7-4ab1-9442-33d976d78021"), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6553), new DateTime(1987, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6553), "Alice", "", "Johnson", "Ally", "Los Angeles", "tester", 70000.0, "Active", "" },
                    { new Guid("85ccb8ee-aa51-4294-8b7d-bdfcc726c373"), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6540), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6540), new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6540), "Jane", "Female", "Smith", "Janey", "London", "Manager", 60000.0, "Inactive", "" },
                    { new Guid("9ba5e402-3ea3-450d-b287-6a98755075f8"), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6555), new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 15, 54, 35, 255, DateTimeKind.Local).AddTicks(6555), "Bob", "", "Brown", "Bobby", "San Francisco", "Developer", 65000.0, "Inactive", "" }
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
