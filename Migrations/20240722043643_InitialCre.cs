using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
