using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eWellness.DL.Migrations
{
    /// <inheritdoc />
    public partial class trxnidtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9836), new DateTime(2024, 11, 14, 1, 53, 24, 198, DateTimeKind.Local).AddTicks(9839), new DateTime(2024, 11, 14, 0, 53, 24, 198, DateTimeKind.Local).AddTicks(9845), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9849), new DateTime(2024, 11, 15, 1, 53, 24, 198, DateTimeKind.Local).AddTicks(9851), new DateTime(2024, 11, 15, 0, 53, 24, 198, DateTimeKind.Local).AddTicks(9853), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9528), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9754), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9760), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9764), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9772), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9780), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9784), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9788), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "TransactionId", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9888), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9891), "pi_import_test", new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 195, DateTimeKind.Local).AddTicks(6590), new DateTime(2024, 11, 12, 23, 53, 24, 195, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 195, DateTimeKind.Local).AddTicks(6598), new DateTime(2024, 11, 12, 23, 53, 24, 195, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 195, DateTimeKind.Local).AddTicks(6602), new DateTime(2024, 11, 12, 23, 53, 24, 195, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9703), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9658), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9665), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9609), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9615), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9438), new DateTime(2004, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9449), "UxEphmqTKVq9d+9gVyljbupJ2BEX5G4Y9+M1EN6QmaIhrfqL", "UxEphmqTKVq9d+9gVyljbg==", new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9459), new DateTime(2002, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9462), "UxEphmqTKVq9d+9gVyljbupJ2BEX5G4Y9+M1EN6QmaIhrfqL", "UxEphmqTKVq9d+9gVyljbg==", new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9465), new DateTime(2000, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9468), "UxEphmqTKVq9d+9gVyljbupJ2BEX5G4Y9+M1EN6QmaIhrfqL", "UxEphmqTKVq9d+9gVyljbg==", new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9467) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "TransactionId",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3317), new DateTime(2024, 10, 3, 0, 52, 38, 798, DateTimeKind.Local).AddTicks(3323), new DateTime(2024, 10, 2, 23, 52, 38, 798, DateTimeKind.Local).AddTicks(3326), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3330), new DateTime(2024, 10, 4, 0, 52, 38, 798, DateTimeKind.Local).AddTicks(3334), new DateTime(2024, 10, 3, 23, 52, 38, 798, DateTimeKind.Local).AddTicks(3336), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3074), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3082), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3107), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3248), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3255), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3261), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3273), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3290), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3296), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "TransactionId", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3359), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 794, DateTimeKind.Local).AddTicks(3622), new DateTime(2024, 10, 1, 22, 52, 38, 794, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 794, DateTimeKind.Local).AddTicks(3664), new DateTime(2024, 10, 1, 22, 52, 38, 794, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 794, DateTimeKind.Local).AddTicks(3670), new DateTime(2024, 10, 1, 22, 52, 38, 794, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3202), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3209), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3214), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3170), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3177), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3140), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2939), new DateTime(2004, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2980), "Y3s7QeyPY5TE75AKxl/mHGYvfSH/aUjaSkkFr+L+A+xq1OhT", "Y3s7QeyPY5TE75AKxl/mHA==", new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2986), new DateTime(2002, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2990), "Y3s7QeyPY5TE75AKxl/mHGYvfSH/aUjaSkkFr+L+A+xq1OhT", "Y3s7QeyPY5TE75AKxl/mHA==", new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2994), new DateTime(2000, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2997), "Y3s7QeyPY5TE75AKxl/mHGYvfSH/aUjaSkkFr+L+A+xq1OhT", "Y3s7QeyPY5TE75AKxl/mHA==", new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2995) });
        }
    }
}
