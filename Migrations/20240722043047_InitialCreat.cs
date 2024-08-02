using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActivityTypes",
                columns: new[] { "Id", "ActivityName", "CreateDate", "DeleteDate", "EditDate" },
                values: new object[,]
                {
                    { new Guid("4474f696-711c-42f1-9100-c0f9f65fe8a3"), "Standard1", new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8480), null, null },
                    { new Guid("b054be0a-8a27-4ad4-95e4-9367103a5188"), "Standard2", new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8490), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("80b629d2-9c10-4179-8646-4ae7cf682eb2"), null, "Standard", "STANDARD" },
                    { new Guid("ec817fe7-8d09-4f66-bfda-98b528a525a6"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "EditDate", "VenueName" },
                values: new object[,]
                {
                    { new Guid("33aaef84-3a25-4e04-a695-2ae972ff7b49"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8310), null, null, "Venue4" },
                    { new Guid("5acb7c37-bf7c-4e95-a775-f9e90874cce0"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8290), null, null, "Venue2" },
                    { new Guid("5d6fd946-9034-42c9-b122-992918b10cc2"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8440), null, null, "Venue13" },
                    { new Guid("6c0120c9-aa59-4ccb-bd7b-3992d3851f80"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8340), null, null, "Venue5" },
                    { new Guid("75592066-dd04-496e-b9fa-f43e30c1a17a"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8390), null, null, "Venue9" },
                    { new Guid("767a75e0-ab9e-4cf1-b10a-683c04cfe3c2"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8460), null, null, "Venue15" },
                    { new Guid("797ce26b-7479-4f6a-bbe6-d09977a0a11a"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8470), null, null, "Venue16" },
                    { new Guid("8cd6fd5b-7cd5-4f1d-80a1-345d38260ab9"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8420), null, null, "Venue12" },
                    { new Guid("8db3d26f-564e-4b45-a89b-d1919443a940"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8350), null, null, "Venue6" },
                    { new Guid("a786da71-f048-40f1-85fc-dbfb3f0d214b"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8410), null, null, "Venue11" },
                    { new Guid("aba2efc8-67ea-41af-8ccd-a436db0bbe29"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8400), null, null, "Venue10" },
                    { new Guid("af11a71a-5c10-425e-accd-05491217542f"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8450), null, null, "Venue14" },
                    { new Guid("d06b2b6a-0397-43dc-a102-106d34b6a112"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8370), null, null, "Venue7" },
                    { new Guid("e05c4d6c-03c1-4736-8667-a1397b9d4cd7"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8240), null, null, "Venue1" },
                    { new Guid("e3ab06ca-a520-4fe4-9c21-4646980a1ab8"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8300), null, null, "Venue3" },
                    { new Guid("ee534a38-8b50-46ec-8367-11cf4aefcd65"), new DateTime(2024, 7, 22, 14, 30, 47, 843, DateTimeKind.Local).AddTicks(8380), null, null, "Venue8" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("4474f696-711c-42f1-9100-c0f9f65fe8a3"));

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("b054be0a-8a27-4ad4-95e4-9367103a5188"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b629d2-9c10-4179-8646-4ae7cf682eb2"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ec817fe7-8d09-4f66-bfda-98b528a525a6"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("33aaef84-3a25-4e04-a695-2ae972ff7b49"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("5acb7c37-bf7c-4e95-a775-f9e90874cce0"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("5d6fd946-9034-42c9-b122-992918b10cc2"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("6c0120c9-aa59-4ccb-bd7b-3992d3851f80"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("75592066-dd04-496e-b9fa-f43e30c1a17a"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("767a75e0-ab9e-4cf1-b10a-683c04cfe3c2"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("797ce26b-7479-4f6a-bbe6-d09977a0a11a"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("8cd6fd5b-7cd5-4f1d-80a1-345d38260ab9"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("8db3d26f-564e-4b45-a89b-d1919443a940"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("a786da71-f048-40f1-85fc-dbfb3f0d214b"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("aba2efc8-67ea-41af-8ccd-a436db0bbe29"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("af11a71a-5c10-425e-accd-05491217542f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("d06b2b6a-0397-43dc-a102-106d34b6a112"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e05c4d6c-03c1-4736-8667-a1397b9d4cd7"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e3ab06ca-a520-4fe4-9c21-4646980a1ab8"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("ee534a38-8b50-46ec-8367-11cf4aefcd65"));
        }
    }
}
