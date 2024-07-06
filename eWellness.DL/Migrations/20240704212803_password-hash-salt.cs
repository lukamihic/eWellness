using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eWellness.DL.Migrations
{
    /// <inheritdoc />
    public partial class passwordhashsalt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordSalt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4120), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4130), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4137), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4143), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4159), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4166), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4172), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4071), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4078), new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4076) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

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
    }
}
