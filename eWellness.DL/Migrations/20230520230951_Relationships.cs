using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eWellness.DL.Migrations
{
    /// <inheritdoc />
    public partial class Relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3544), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3550), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3556), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3561), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3567), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3574), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3580), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3585), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3489), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3498), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3504), new DateTime(2023, 5, 21, 1, 9, 51, 177, DateTimeKind.Local).AddTicks(3502) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(5988), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(5996), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6002), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(5936), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(5946), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(5953), new DateTime(2023, 5, 14, 22, 34, 42, 897, DateTimeKind.Local).AddTicks(5951) });
        }
    }
}
