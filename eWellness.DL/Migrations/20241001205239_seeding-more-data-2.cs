using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eWellness.DL.Migrations
{
    /// <inheritdoc />
    public partial class seedingmoredata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "ClientId", "CreatedAt", "EmployeeId", "EndTime", "IsDeleted", "Notes", "ServiceId", "SpecialOfferId", "StartTime", "Status", "TotalPrice", "UpdatedAt" },
                values: new object[] { 1, 1, new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3317), null, new DateTime(2024, 10, 3, 0, 52, 38, 798, DateTimeKind.Local).AddTicks(3323), false, "Demo note", 1, null, new DateTime(2024, 10, 2, 23, 52, 38, 798, DateTimeKind.Local).AddTicks(3326), "COMPLETED", 40m, new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3074), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3071) });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "EmergencyContactName", "EmergencyContactPhone", "Gender", "IsDeleted", "Name", "PasswordHash", "PasswordSalt", "Phone", "UpdatedAt" },
                values: new object[] { 3, "Test address no1", new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2994), new DateTime(2000, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2997), "test_client", "N/A", "N/A", "M", false, "Test Client", "Y3s7QeyPY5TE75AKxl/mHGYvfSH/aUjaSkkFr+L+A+xq1OhT", "Y3s7QeyPY5TE75AKxl/mHA==", "0000000000", new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "IsMember", "LastAppointment", "MembershipExpirationDate", "TotalAppointments", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3082), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 0, new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3080), 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "AppointmentId", "CreatedAt", "Date", "Fees", "IsDeleted", "PaymentMethodId", "TransactionId", "UpdatedAt" },
                values: new object[] { 1, 40m, 1, new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3359), 0m, false, 3, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "ClientId", "CreatedAt", "EmployeeId", "EndTime", "IsDeleted", "Notes", "ServiceId", "SpecialOfferId", "StartTime", "Status", "TotalPrice", "UpdatedAt" },
                values: new object[] { 2, 2, new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3330), null, new DateTime(2024, 10, 4, 0, 52, 38, 798, DateTimeKind.Local).AddTicks(3334), false, "Demo note", 1, null, new DateTime(2024, 10, 3, 23, 52, 38, 798, DateTimeKind.Local).AddTicks(3336), "RESERVED", 40m, new DateTime(2024, 10, 1, 22, 52, 38, 798, DateTimeKind.Local).AddTicks(3332) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2247), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2245) });

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

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2332), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2337), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2297), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "SpecialOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2304), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2276), new DateTime(2024, 10, 1, 20, 39, 58, 66, DateTimeKind.Local).AddTicks(2278) });

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
    }
}
