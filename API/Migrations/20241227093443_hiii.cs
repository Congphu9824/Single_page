using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class hiii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1e4739ac-b5c4-47bd-a41f-9b0eaa0eb06d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4178b3e7-72d1-43bc-b1c7-b8b4cfcc5af5"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("0fd42793-abd9-498c-babf-fef8dca8a0c1"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("2b10409f-2710-48ac-a730-ac8c39e2f543"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("37c03f7f-1be7-4ab1-9442-33d976d78021"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("85ccb8ee-aa51-4294-8b7d-bdfcc726c373"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("9ba5e402-3ea3-450d-b287-6a98755075f8"));

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "DateCreated", "StaffId", "Text" },
                values: new object[,]
                {
                    { new Guid("4de23ef2-2adf-44a9-99d0-277514ea721d"), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2837), null, "Welcome Note" },
                    { new Guid("bd459d05-c735-495d-8017-94d51c69599c"), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2845), null, "Take note" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateOfBirth", "DateUpdated", "FirstName", "Gender", "LastName", "NickName", "Place", "Position", "Salary", "Status", "loacation" },
                values: new object[,]
                {
                    { new Guid("058f53b1-afbe-4f70-bc99-13aad3469aaa"), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2759), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2760), new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2760), "Bob", "", "Brown", "Bobby", "San Francisco", "Developer", 65000.0, "Inactive", "" },
                    { new Guid("0db85d50-f604-46fc-9ee2-71766b6bf24a"), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2752), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2752), new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2752), "Jane", "Female", "Smith", "Janey", "London", "Manager", 60000.0, "Inactive", "" },
                    { new Guid("77883fe1-a445-467f-b81d-c1531478777a"), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2722), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2734), new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2731), "John", "Male", "Doe", "Johnny", "New York", "Developer", 50000.0, "Active", "" },
                    { new Guid("ab1d47a1-7087-41e8-89f0-c24043e825eb"), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2755), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2755), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2755), "John", "", "Doe", "Johnny", "New York", "Designer", 55000.0, "Active", "" },
                    { new Guid("d0263cd5-f324-424e-b136-aed0754981e8"), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2757), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2758), new DateTime(1987, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 16, 34, 43, 700, DateTimeKind.Local).AddTicks(2757), "Alice", "", "Johnson", "Ally", "Los Angeles", "tester", 70000.0, "Active", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4de23ef2-2adf-44a9-99d0-277514ea721d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("bd459d05-c735-495d-8017-94d51c69599c"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("058f53b1-afbe-4f70-bc99-13aad3469aaa"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("0db85d50-f604-46fc-9ee2-71766b6bf24a"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("77883fe1-a445-467f-b81d-c1531478777a"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("ab1d47a1-7087-41e8-89f0-c24043e825eb"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("d0263cd5-f324-424e-b136-aed0754981e8"));

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
        }
    }
}
