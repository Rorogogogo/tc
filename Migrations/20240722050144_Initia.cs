using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class Initia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("7f802d75-8545-4c2f-9be8-2c771f6915a6"));

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("f71477fe-5656-4f2a-a2a0-513ef80b29b6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4ce7e4dc-188c-44de-9b8f-c22741c8cac7"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7d002a96-528d-46ff-bc83-491013a4b9c1"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("0a1268b0-0dac-41d7-af21-187340930967"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("23276cce-33e9-4a05-a35c-6dde86bc942f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("2e6d57b7-692f-45bd-91b6-6fb94f38f3cc"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("33043b3d-0975-4d60-b254-b14932cbb91f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("34f87a24-bd75-4bec-b53f-b740afadc75c"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("404be62c-69d8-4a9d-9850-b3ad6320665b"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("4f97d92d-0386-424f-bb0f-e3b281cb689e"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("602233e3-cf82-4565-9575-9d9925154977"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("6210d9c0-1ac0-4acc-989d-564bb24e23a6"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("63a959e4-b901-4702-9b8f-60bef9b3b313"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("6f6bf215-1278-4b39-8b07-7adc2d0cf0a4"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("8f03f5db-905c-4473-a7b6-e0ea0864c303"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("954d313f-0d84-4a6d-95bd-b669ef89159b"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("9f810a29-4caa-48fc-8ffc-be310c328bb4"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("a97af589-1a67-46cf-878f-d519df6de6f3"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("ad3fbdc8-0999-42a4-aec3-046c941fd0b3"));

            migrationBuilder.InsertData(
                table: "ActivityTypes",
                columns: new[] { "Id", "ActivityName", "CreateDate", "DeleteDate", "EditDate" },
                values: new object[,]
                {
                    { new Guid("0312c77a-2558-45a0-a081-3786243a18b7"), "Standard2", new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3540), null, null },
                    { new Guid("c4e7d93c-0ece-4610-bda6-1a82c2a21158"), "Standard1", new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3530), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1f261c82-bbab-4dc9-b394-915e18dbf581"), null, "Admin", "ADMIN" },
                    { new Guid("6aee5453-b064-4760-b0d9-47bade609c82"), null, "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "EditDate", "VenueName" },
                values: new object[,]
                {
                    { new Guid("04b3fa98-69c6-4434-b487-4b671242f7c1"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3420), null, null, "Venue9" },
                    { new Guid("07e17499-b6fb-45a4-9a40-5075222c773a"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3390), null, null, "Venue6" },
                    { new Guid("27623715-3646-4941-9ce8-40bfd1761158"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3410), null, null, "Venue8" },
                    { new Guid("2dfd9366-ef76-4186-af0f-b345a0d3f35c"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3360), null, null, "Venue4" },
                    { new Guid("4b491c29-b94b-4902-8545-9114bb2646e1"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3270), null, null, "Venue1" },
                    { new Guid("79a898bc-b18b-475b-9042-50d03753ac53"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3330), null, null, "Venue2" },
                    { new Guid("87737ae3-860f-4f14-95a4-db29ddab5b3b"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3450), null, null, "Venue10" },
                    { new Guid("8a08edd5-576a-4bb3-a652-590cc3e5ad7f"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3520), null, null, "Venue16" },
                    { new Guid("98608c7e-9593-4113-93b9-4f11f9170e0e"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3400), null, null, "Venue7" },
                    { new Guid("b60b7146-bdbe-483e-80fd-bc24a2b9dcc7"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3510), null, null, "Venue15" },
                    { new Guid("e571e407-d989-444a-8dd4-d1f25df6443a"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3470), null, null, "Venue12" },
                    { new Guid("e59debe1-f332-4f16-a051-8157d266c2ee"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3490), null, null, "Venue13" },
                    { new Guid("ea861fad-16c1-46c3-ae2b-f98bb77d5278"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3370), null, null, "Venue5" },
                    { new Guid("eb945727-d571-4128-a72f-0593a5f8d94f"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3350), null, null, "Venue3" },
                    { new Guid("ee604752-61d2-49ac-a06d-87c6397cf25c"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3500), null, null, "Venue14" },
                    { new Guid("f56aa909-4da5-4390-a5d0-79c74f017397"), new DateTime(2024, 7, 22, 15, 1, 44, 299, DateTimeKind.Local).AddTicks(3460), null, null, "Venue11" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("0312c77a-2558-45a0-a081-3786243a18b7"));

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("c4e7d93c-0ece-4610-bda6-1a82c2a21158"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f261c82-bbab-4dc9-b394-915e18dbf581"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6aee5453-b064-4760-b0d9-47bade609c82"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("04b3fa98-69c6-4434-b487-4b671242f7c1"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("07e17499-b6fb-45a4-9a40-5075222c773a"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("27623715-3646-4941-9ce8-40bfd1761158"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("2dfd9366-ef76-4186-af0f-b345a0d3f35c"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("4b491c29-b94b-4902-8545-9114bb2646e1"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("79a898bc-b18b-475b-9042-50d03753ac53"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("87737ae3-860f-4f14-95a4-db29ddab5b3b"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("8a08edd5-576a-4bb3-a652-590cc3e5ad7f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("98608c7e-9593-4113-93b9-4f11f9170e0e"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b60b7146-bdbe-483e-80fd-bc24a2b9dcc7"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e571e407-d989-444a-8dd4-d1f25df6443a"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e59debe1-f332-4f16-a051-8157d266c2ee"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("ea861fad-16c1-46c3-ae2b-f98bb77d5278"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("eb945727-d571-4128-a72f-0593a5f8d94f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("ee604752-61d2-49ac-a06d-87c6397cf25c"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("f56aa909-4da5-4390-a5d0-79c74f017397"));

            migrationBuilder.InsertData(
                table: "ActivityTypes",
                columns: new[] { "Id", "ActivityName", "CreateDate", "DeleteDate", "EditDate" },
                values: new object[,]
                {
                    { new Guid("7f802d75-8545-4c2f-9be8-2c771f6915a6"), "Standard2", new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2350), null, null },
                    { new Guid("f71477fe-5656-4f2a-a2a0-513ef80b29b6"), "Standard1", new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2340), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("4ce7e4dc-188c-44de-9b8f-c22741c8cac7"), null, "Admin", "ADMIN" },
                    { new Guid("7d002a96-528d-46ff-bc83-491013a4b9c1"), null, "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "EditDate", "VenueName" },
                values: new object[,]
                {
                    { new Guid("0a1268b0-0dac-41d7-af21-187340930967"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2220), null, null, "Venue7" },
                    { new Guid("23276cce-33e9-4a05-a35c-6dde86bc942f"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2230), null, null, "Venue8" },
                    { new Guid("2e6d57b7-692f-45bd-91b6-6fb94f38f3cc"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2280), null, null, "Venue12" },
                    { new Guid("33043b3d-0975-4d60-b254-b14932cbb91f"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2330), null, null, "Venue16" },
                    { new Guid("34f87a24-bd75-4bec-b53f-b740afadc75c"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2180), null, null, "Venue4" },
                    { new Guid("404be62c-69d8-4a9d-9850-b3ad6320665b"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2170), null, null, "Venue3" },
                    { new Guid("4f97d92d-0386-424f-bb0f-e3b281cb689e"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2270), null, null, "Venue11" },
                    { new Guid("602233e3-cf82-4565-9575-9d9925154977"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2100), null, null, "Venue1" },
                    { new Guid("6210d9c0-1ac0-4acc-989d-564bb24e23a6"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2260), null, null, "Venue10" },
                    { new Guid("63a959e4-b901-4702-9b8f-60bef9b3b313"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2300), null, null, "Venue13" },
                    { new Guid("6f6bf215-1278-4b39-8b07-7adc2d0cf0a4"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2150), null, null, "Venue2" },
                    { new Guid("8f03f5db-905c-4473-a7b6-e0ea0864c303"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2310), null, null, "Venue14" },
                    { new Guid("954d313f-0d84-4a6d-95bd-b669ef89159b"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2320), null, null, "Venue15" },
                    { new Guid("9f810a29-4caa-48fc-8ffc-be310c328bb4"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2210), null, null, "Venue6" },
                    { new Guid("a97af589-1a67-46cf-878f-d519df6de6f3"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2250), null, null, "Venue9" },
                    { new Guid("ad3fbdc8-0999-42a4-aec3-046c941fd0b3"), new DateTime(2024, 7, 22, 15, 0, 31, 264, DateTimeKind.Local).AddTicks(2190), null, null, "Venue5" }
                });
        }
    }
}
