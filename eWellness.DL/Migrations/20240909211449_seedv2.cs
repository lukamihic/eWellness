using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eWellness.DL.Migrations
{
    /// <inheritdoc />
    public partial class seedv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PasswordSalt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2264), "Mastercard cards", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2273), "Visa cards", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2279), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2285), "Diners Club cards", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2291), "Discovery cards", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2301), "Voucher payments", "Voucher", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2307), "Pay by bank transfer", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2313), "Cash payment", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4703), "Various face and body massages", "Massage", new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4719), "Various maderotherapies", "Maderotherapy", new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4728), "Spa spaces", new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedAt", "Description", "Duration", "ImageUrl", "IsAvailable", "IsDeleted", "Name", "Price", "ServiceCategoryId", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2105), "Massage of the whole body for an hour", 60, "https://i1.sndcdn.com/artworks-000135911201-ryi7ns-t500x500.jpg", true, false, "Full body massage", 40m, 1, new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.InsertData(
                table: "SpecialOffers",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "IsDeleted", "Name", "OfferExpirationDate", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2077), "Welcome to the app, enjoy it!", true, false, "Enjoy :)", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "EmergencyContactName", "EmergencyContactPhone", "Gender", "IsDeleted", "Name", "PasswordHash", "PasswordSalt", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Test address no1", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1900), new DateTime(2004, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1939), "desktop", "N/A", "N/A", "M", false, "Desktop App", "K/sOnk85CGvUFLw0m2NCE1tL1ilUhM5715CBnC/DBwDUxCiU", "K/sOnk85CGvUFLw0m2NCEw==", "0000000000", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1931) },
                    { 2, "Test address no2", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1949), new DateTime(2002, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1952), "mobile", "N/A", "N/A", "M", false, "Mobile App", "K/sOnk85CGvUFLw0m2NCE1tL1ilUhM5715CBnC/DBwDUxCiU", "K/sOnk85CGvUFLw0m2NCEw==", "0000000000", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1951) }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "IsMember", "LastAppointment", "MembershipExpirationDate", "TotalAppointments", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2024), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 0, new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2022), 2 });

            migrationBuilder.InsertData(
                table: "Tips",
                columns: new[] { "Id", "CreatedAt", "CreatedByUserId", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2053), 1, "Welcome to the app, enjoy it!", true, false, "Enjoy :)", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2055) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordSalt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4120), "Mastercard kartice", new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4130), "Visa kartice", new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4127) });

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
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4143), "Diners Club kartice", new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4150), "Discovery kartice", new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4159), "Plaćanje vaučerom", "Vaučer", new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4166), "Virmansko plaćanje", new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4172), "Gotovinsko plaćanje", new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4058), "Različite masaže tijela i lica", "Masaža", new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4071), "Različite maderoterapije tijela i lica", "Maderoterapija", new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4078), "Spa prostorije u kojima nema manuelnog rada", new DateTime(2024, 7, 4, 23, 28, 2, 968, DateTimeKind.Local).AddTicks(4076) });
        }
    }
}
