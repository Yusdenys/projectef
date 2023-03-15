using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("d4946f70-bfa7-41ea-b33b-8447b9d1f8dc"), null, "Actividades personales", 50 },
                    { new Guid("d93a7c12-af4b-433a-ab44-8a94e2135bca"), null, "Actividades pendientes", 20 }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "CategoryId", "CreateDate", "Description", "Owner", "PriorityTask", "Title" },
                values: new object[,]
                {
                    { new Guid("6d996402-9beb-4490-b50f-5a170c21c6b3"), new Guid("d93a7c12-af4b-433a-ab44-8a94e2135bca"), new DateTime(2023, 3, 14, 10, 15, 43, 737, DateTimeKind.Local).AddTicks(3928), null, "Yusdenys Perez", 1, "Pago servicios publicos" },
                    { new Guid("d1555e02-9d28-4d87-834a-c2d9c9a2c2c4"), new Guid("d4946f70-bfa7-41ea-b33b-8447b9d1f8dc"), new DateTime(2023, 3, 14, 10, 15, 43, 737, DateTimeKind.Local).AddTicks(3973), null, "Yusdenys Perez", 2, "Pago servicios privados" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("6d996402-9beb-4490-b50f-5a170c21c6b3"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("d1555e02-9d28-4d87-834a-c2d9c9a2c2c4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("d4946f70-bfa7-41ea-b33b-8447b9d1f8dc"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("d93a7c12-af4b-433a-ab44-8a94e2135bca"));
        }
    }
}
