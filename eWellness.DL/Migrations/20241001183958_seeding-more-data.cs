using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eWellness.DL.Migrations
{
    /// <inheritdoc />
    public partial class seedingmoredata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Position", "Salary", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2247), false, "Admin", 5000m, new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2245), 1 });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2362), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2370), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2376), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2382), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2388), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2396), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2408), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 62, DateTimeKind.Local).AddTicks(4305), new DateTime(2024, 10, 1, 20, 39, 58, 62, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 62, DateTimeKind.Local).AddTicks(4314), new DateTime(2024, 10, 1, 20, 39, 58, 62, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 62, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 10, 1, 20, 39, 58, 62, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2325), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedAt", "Description", "Duration", "ImageUrl", "IsAvailable", "IsDeleted", "Name", "Price", "ServiceCategoryId", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2332), "Sauna visit for half an hour", 30, "https://i1.sndcdn.com/artworks-000135911201-ryi7ns-t500x500.jpg", true, false, "Sauna", 10m, 3, new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2334) },
                    { 3, new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2337), "Maderotherapy", 30, "https://i1.sndcdn.com/artworks-000135911201-ryi7ns-t500x500.jpg", true, false, "Maderotherapy", 50m, 2, new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2339) }
                });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2297), "Get three massages for the price of two", "2 + 1", new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.InsertData(
                table: "SpecialOffers",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "IsDeleted", "Name", "OfferExpirationDate", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2304), "Get seven sauna visits for the price of five", true, false, "5 + 2", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.InsertData(
                table: "Tips",
                columns: new[] { "Id", "CreatedAt", "CreatedByUserId", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2276), 1, "Cold baths strengthen immunity and improve blood flow.", true, false, "Cold baths brrr", new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2171), new DateTime(2004, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2182), "RFegfD2KvqhwTUINxxvZGT4940qyzf3sUueYiT9luUEIEifL", "RFegfD2KvqhwTUINxxvZGQ==", new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2189), new DateTime(2002, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2193), "RFegfD2KvqhwTUINxxvZGT4940qyzf3sUueYiT9luUEIEifL", "RFegfD2KvqhwTUINxxvZGQ==", new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2191) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2264), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2273), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2271) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2285), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2291), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2301), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2307), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4719), new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4728), new DateTime(2024, 9, 9, 23, 14, 49, 215, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2105), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2077), "Welcome to the app, enjoy it!", "Enjoy :)", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2053), new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1900), new DateTime(2004, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1939), "K/sOnk85CGvUFLw0m2NCE1tL1ilUhM5715CBnC/DBwDUxCiU", "K/sOnk85CGvUFLw0m2NCEw==", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1949), new DateTime(2002, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1952), "K/sOnk85CGvUFLw0m2NCE1tL1ilUhM5715CBnC/DBwDUxCiU", "K/sOnk85CGvUFLw0m2NCEw==", new DateTime(2024, 9, 9, 23, 14, 49, 219, DateTimeKind.Local).AddTicks(1951) });
        }
    }
}
