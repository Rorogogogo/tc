using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("653ec9fb-aaba-4b9c-9558-a4518007a5c8"));

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("f6d64886-d5c7-4665-bd63-2cf7dd1f8124"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("871a3165-f773-4e1c-8f46-86dcef517587"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e60bd27e-3f13-4628-852a-d7be42a298b9"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("01e5f736-7fc3-43a8-8612-29c9ed07d329"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("04239973-475d-4c4d-bc1e-3bd5ba9c8e85"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("38c5b49b-2e20-4d1f-b934-68bdff8f7769"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("3b7ad237-33ad-428d-9d2e-3855e92f94ee"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("5acab732-976a-4e67-bc1e-e81104d6e6d4"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("6c270ce7-9ea0-47a4-b97a-2f6d40d10bc7"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("8e6d71ce-289e-4204-ae27-d03ced4fc2fd"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("a1872eee-5399-4394-9821-e0bd05adc4ee"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("a58094ca-2748-4c84-a9a0-3a2ea4b841bb"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("af0e6477-7388-498d-8f9c-3730e8173b84"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b180dfc0-298d-4c6d-8441-f686dddb2176"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b3b3301b-0894-4d11-8d82-221d5d7ce527"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e3400e1f-2678-4010-aa05-eacc7fc19c58"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e38788da-ed5c-4c04-9bae-d31338674fda"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("eb595a0a-4622-4116-af87-ae8910937433"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("fabebb92-75c6-4010-b02f-b54b21420158"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("653ec9fb-aaba-4b9c-9558-a4518007a5c8"), "Standard2", new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9280), null, null },
                    { new Guid("f6d64886-d5c7-4665-bd63-2cf7dd1f8124"), "Standard1", new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9270), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("871a3165-f773-4e1c-8f46-86dcef517587"), null, "Standard", "STANDARD" },
                    { new Guid("e60bd27e-3f13-4628-852a-d7be42a298b9"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "EditDate", "VenueName" },
                values: new object[,]
                {
                    { new Guid("01e5f736-7fc3-43a8-8612-29c9ed07d329"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9070), null, null, "Venue2" },
                    { new Guid("04239973-475d-4c4d-bc1e-3bd5ba9c8e85"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9090), null, null, "Venue3" },
                    { new Guid("38c5b49b-2e20-4d1f-b934-68bdff8f7769"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9230), null, null, "Venue14" },
                    { new Guid("3b7ad237-33ad-428d-9d2e-3855e92f94ee"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9100), null, null, "Venue4" },
                    { new Guid("5acab732-976a-4e67-bc1e-e81104d6e6d4"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9200), null, null, "Venue12" },
                    { new Guid("6c270ce7-9ea0-47a4-b97a-2f6d40d10bc7"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9170), null, null, "Venue9" },
                    { new Guid("8e6d71ce-289e-4204-ae27-d03ced4fc2fd"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9240), null, null, "Venue15" },
                    { new Guid("a1872eee-5399-4394-9821-e0bd05adc4ee"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9130), null, null, "Venue6" },
                    { new Guid("a58094ca-2748-4c84-a9a0-3a2ea4b841bb"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9210), null, null, "Venue13" },
                    { new Guid("af0e6477-7388-498d-8f9c-3730e8173b84"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9150), null, null, "Venue8" },
                    { new Guid("b180dfc0-298d-4c6d-8441-f686dddb2176"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9190), null, null, "Venue11" },
                    { new Guid("b3b3301b-0894-4d11-8d82-221d5d7ce527"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9110), null, null, "Venue5" },
                    { new Guid("e3400e1f-2678-4010-aa05-eacc7fc19c58"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(8790), null, null, "Venue1" },
                    { new Guid("e38788da-ed5c-4c04-9bae-d31338674fda"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9140), null, null, "Venue7" },
                    { new Guid("eb595a0a-4622-4116-af87-ae8910937433"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9180), null, null, "Venue10" },
                    { new Guid("fabebb92-75c6-4010-b02f-b54b21420158"), new DateTime(2024, 7, 22, 14, 36, 43, 148, DateTimeKind.Local).AddTicks(9250), null, null, "Venue16" }
                });
        }
    }
}
