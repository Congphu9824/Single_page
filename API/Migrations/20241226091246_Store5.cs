using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Store5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateOfBirth", "DateUpdated", "FirstName", "Gender", "LastName", "NickName", "Place", "Position", "Salary", "Status", "loacation" },
                values: new object[,]
                {
                    { new Guid("1a56d2a4-8213-4fd7-9ff4-4c22ba14d854"), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9233), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9234), new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9234), "Jane", "Female", "Smith", "Janey", "London", "Manager", 60000.0, "Inactive", "" },
                    { new Guid("a009d280-4ab1-4c75-9fab-af15f5f97a2a"), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9237), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9237), "John", "", "Doe", "Johnny", "New York", "Designer", 55000.0, "Active", "" },
                    { new Guid("a745ece2-e2db-43be-a24b-18c7647ed7b6"), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9196), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9208), new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9205), "John", "Male", "Doe", "Johnny", "New York", "Developer", 50000.0, "Active", "" },
                    { new Guid("ca0df4c8-9389-4240-9270-391a80ab98e6"), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9239), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9240), new DateTime(1987, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9239), "Alice", "", "Johnson", "Ally", "Los Angeles", "tester", 70000.0, "Active", "" },
                    { new Guid("f4ee3099-1d30-4719-aba0-0aa597dc8893"), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9242), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9242), new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9242), "Bob", "", "Brown", "Bobby", "San Francisco", "Developer", 65000.0, "Inactive", "" }
                });

            migrationBuilder.InsertData(
                table: "notes",
                columns: new[] { "Id", "DateCreated", "StaffId", "Text" },
                values: new object[,]
                {
                    { new Guid("ed66bc23-56d9-4c13-90ba-917b2ca55c82"), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9316), null, "Take note" },
                    { new Guid("fbe6317c-1439-48fc-8f69-9b8fbf9a8e48"), new DateTime(2024, 12, 26, 16, 12, 45, 101, DateTimeKind.Local).AddTicks(9315), null, "Welcome Note" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("1a56d2a4-8213-4fd7-9ff4-4c22ba14d854"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("a009d280-4ab1-4c75-9fab-af15f5f97a2a"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("a745ece2-e2db-43be-a24b-18c7647ed7b6"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("ca0df4c8-9389-4240-9270-391a80ab98e6"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("f4ee3099-1d30-4719-aba0-0aa597dc8893"));

            migrationBuilder.DeleteData(
                table: "notes",
                keyColumn: "Id",
                keyValue: new Guid("ed66bc23-56d9-4c13-90ba-917b2ca55c82"));

            migrationBuilder.DeleteData(
                table: "notes",
                keyColumn: "Id",
                keyValue: new Guid("fbe6317c-1439-48fc-8f69-9b8fbf9a8e48"));

            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "Staffs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
