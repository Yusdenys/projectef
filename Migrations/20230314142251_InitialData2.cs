using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "Name", "Weight" },
                values: new object[] { new Guid("d4946f70-bfa7-41ea-b33b-8447b9d1f8de"), null, "Actividades de terceros", 5 });

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("6d996402-9beb-4490-b50f-5a170c21c6b3"),
                column: "CreateDate",
                value: new DateTime(2023, 3, 14, 10, 22, 51, 160, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("d1555e02-9d28-4d87-834a-c2d9c9a2c2c4"),
                column: "CreateDate",
                value: new DateTime(2023, 3, 14, 10, 22, 51, 160, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "CategoryId", "CreateDate", "Description", "Owner", "PriorityTask", "Title" },
                values: new object[] { new Guid("d1555e02-9d28-4d87-834a-c2d9c9a2c2c5"), new Guid("d4946f70-bfa7-41ea-b33b-8447b9d1f8de"), new DateTime(2023, 3, 14, 10, 22, 51, 160, DateTimeKind.Local).AddTicks(3443), null, "Yusdenys Perez", 0, "Llamar telefono" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("d1555e02-9d28-4d87-834a-c2d9c9a2c2c5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("d4946f70-bfa7-41ea-b33b-8447b9d1f8de"));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("6d996402-9beb-4490-b50f-5a170c21c6b3"),
                column: "CreateDate",
                value: new DateTime(2023, 3, 14, 10, 15, 43, 737, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("d1555e02-9d28-4d87-834a-c2d9c9a2c2c4"),
                column: "CreateDate",
                value: new DateTime(2023, 3, 14, 10, 15, 43, 737, DateTimeKind.Local).AddTicks(3973));
        }
    }
}
