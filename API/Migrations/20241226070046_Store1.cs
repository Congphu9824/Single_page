using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Store1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateOfBirth", "DateUpdated", "FirstName", "Gender", "LastName", "NickName", "Place", "Position", "Salary", "Status", "loacation" },
                values: new object[,]
                {
                    { new Guid("7288f590-3256-4b1e-89df-b7554cef8349"), new DateTime(2024, 12, 26, 14, 0, 46, 302, DateTimeKind.Local).AddTicks(7945), new DateTime(2024, 12, 26, 14, 0, 46, 302, DateTimeKind.Local).AddTicks(7945), new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 14, 0, 46, 302, DateTimeKind.Local).AddTicks(7945), "Jane", "Female", "Smith", "Janey", "London", 0, 60000.0, "Inactive", "" },
                    { new Guid("bc0fbf76-5780-4a93-9b6c-819d9151aef3"), new DateTime(2024, 12, 26, 14, 0, 46, 302, DateTimeKind.Local).AddTicks(7902), new DateTime(2024, 12, 26, 14, 0, 46, 302, DateTimeKind.Local).AddTicks(7915), new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 14, 0, 46, 302, DateTimeKind.Local).AddTicks(7912), "John", "Male", "Doe", "Johnny", "New York", 1, 50000.0, "Active", "" }
                });

            migrationBuilder.InsertData(
                table: "notes",
                columns: new[] { "Id", "DateCreated", "StaffId", "Text" },
                values: new object[] { new Guid("4fb65b1f-e856-4ef3-91f7-e706a875cc2e"), new DateTime(2024, 12, 26, 14, 0, 46, 302, DateTimeKind.Local).AddTicks(8021), null, "Welcome Note" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("7288f590-3256-4b1e-89df-b7554cef8349"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("bc0fbf76-5780-4a93-9b6c-819d9151aef3"));

            migrationBuilder.DeleteData(
                table: "notes",
                keyColumn: "Id",
                keyValue: new Guid("4fb65b1f-e856-4ef3-91f7-e706a875cc2e"));
        }
    }
}
