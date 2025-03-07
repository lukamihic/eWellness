using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eWellness.DL.Migrations
{
    /// <inheritdoc />
    public partial class changeseedsdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7622), new DateTime(2025, 2, 14, 19, 38, 44, 422, DateTimeKind.Local).AddTicks(7628), new DateTime(2025, 2, 14, 18, 38, 44, 422, DateTimeKind.Local).AddTicks(7640), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7647), new DateTime(2025, 2, 15, 19, 38, 44, 422, DateTimeKind.Local).AddTicks(7651), new DateTime(2025, 2, 15, 18, 38, 44, 422, DateTimeKind.Local).AddTicks(7655), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6854), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6869), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6942), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7471), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7483), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7491), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7499), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7507), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7521), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7529), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7537), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7720), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7726), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 417, DateTimeKind.Local).AddTicks(9444), new DateTime(2025, 2, 13, 17, 38, 44, 417, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 417, DateTimeKind.Local).AddTicks(9456), new DateTime(2025, 2, 13, 17, 38, 44, 417, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 417, DateTimeKind.Local).AddTicks(9463), new DateTime(2025, 2, 13, 17, 38, 44, 417, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7178), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7191), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7199), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OfferExpirationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7091), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OfferExpirationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7109), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7008), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7020), new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6657), new DateTime(2005, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6691), "RpcvQ2cT/s7O3VKSuCaHOmS9HtVFOmpEl4ddT4TufDaSrRAZ", "RpcvQ2cT/s7O3VKSuCaHOg==", new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6714), new DateTime(2003, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6718), "RpcvQ2cT/s7O3VKSuCaHOmS9HtVFOmpEl4ddT4TufDaSrRAZ", "RpcvQ2cT/s7O3VKSuCaHOg==", new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6724), new DateTime(2001, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6729), "RpcvQ2cT/s7O3VKSuCaHOmS9HtVFOmpEl4ddT4TufDaSrRAZ", "RpcvQ2cT/s7O3VKSuCaHOg==", new DateTime(2025, 2, 13, 17, 38, 44, 422, DateTimeKind.Local).AddTicks(6726) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9888), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9891), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9890) });

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
                columns: new[] { "CreatedAt", "OfferExpirationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9658), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OfferExpirationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9665), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new DateTime(2024, 11, 12, 23, 53, 24, 198, DateTimeKind.Local).AddTicks(9666) });

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
    }
}
