using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class newDB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("06e32f25-a796-41bf-a3e6-960729c2d5a2"));

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("b109780a-988a-4186-b95e-a5916137f7eb"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("93f56303-eaec-4f81-8a0a-6f8ddbbde71e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d00c788d-d745-4828-bf8c-b096c56553b0"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("0ef8afde-ec4b-4577-8014-81731e486d53"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("213ed478-72fa-402d-86fc-cb124ca7f493"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("7438cbef-f0c0-43b2-bef1-a5c57b09d895"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("8ac0830f-bb35-4c82-a907-038b6f1af47f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("8dbb6163-a4af-4085-bdc1-42e17b1074c5"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("91653fce-531c-4425-9cda-b5a8bc3f3b90"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("946bbaea-f379-4bf0-95a6-97be7c5aacd8"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("9a595615-00d8-422c-acda-a4da2d8588bb"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("a8de4114-0136-4f20-a86b-658c084d3c8f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b08534b6-5a5c-48a3-ac71-286712f32c93"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b67f73a1-8416-488c-a21c-0f6bb5d694f8"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("d0ec3db0-90c6-4ef6-9681-6346135c329b"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("dfe5487d-a335-475b-9d40-b65f41d22129"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e535ae14-01e1-4d5e-a29a-abcec3840881"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e917b31a-3c53-48c4-994b-f1dc74f6ba58"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e9d95cfe-d5ed-43b6-87d7-b2509f12b5ec"));

            migrationBuilder.InsertData(
                table: "ActivityTypes",
                columns: new[] { "Id", "ActivityName", "CreateDate", "DeleteDate", "EditDate" },
                values: new object[,]
                {
                    { new Guid("5e907643-1b38-48fa-8eb0-e1686c025947"), "Standard2", new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1920), null, null },
                    { new Guid("6f47efed-1d4e-4196-aeeb-c69a05dc693b"), "Standard1", new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1920), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("03609fd3-32a1-4aad-ba34-3f5b8ccbf7bc"), null, "Standard", "STANDARD" },
                    { new Guid("c7e9509d-1345-477d-ba3f-64fd5f22db64"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "EditDate", "VenueName" },
                values: new object[,]
                {
                    { new Guid("27052b7c-585c-4423-bb92-8ae721fecf36"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1800), null, null, "Venue8" },
                    { new Guid("44dae368-bf84-4c59-a334-67214fdd54c5"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1750), null, null, "Venue4" },
                    { new Guid("47e5c39d-fe80-42e8-bc4a-2c5273c54784"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1790), null, null, "Venue7" },
                    { new Guid("5ec2aa7a-c2d6-4d11-8b63-702d635d2555"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1890), null, null, "Venue15" },
                    { new Guid("8223cb24-26b8-44e9-b5fc-3509a64af6bb"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1860), null, null, "Venue13" },
                    { new Guid("960c65a6-af65-4fd8-8251-ef8ae040fbd8"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1660), null, null, "Venue1" },
                    { new Guid("9e477352-e487-4148-b0be-195793d497d2"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1810), null, null, "Venue9" },
                    { new Guid("ae6b6c4e-9f96-4238-9e40-bf1a34d86d3f"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1760), null, null, "Venue5" },
                    { new Guid("b1539c49-9eb0-4ab5-9ad0-0ab2e6d92685"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1900), null, null, "Venue16" },
                    { new Guid("bbd81d4a-5042-4a26-9451-a44d099a35d3"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1740), null, null, "Venue3" },
                    { new Guid("be959c01-4b40-40e0-b969-c961d1193614"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1850), null, null, "Venue12" },
                    { new Guid("d0d37d81-906a-40cd-9bf6-ed141c92966d"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1840), null, null, "Venue11" },
                    { new Guid("d80f47d7-0f14-4360-b776-1362124c96ae"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1820), null, null, "Venue10" },
                    { new Guid("df043272-4df0-4bb1-9687-50adfdb9bba5"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1880), null, null, "Venue14" },
                    { new Guid("f0ca534e-4bf2-41f6-8720-a964f079f3cf"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1720), null, null, "Venue2" },
                    { new Guid("fac43fc2-c23b-481d-8a35-bd8af895b7ee"), new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1780), null, null, "Venue6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("5e907643-1b38-48fa-8eb0-e1686c025947"));

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("6f47efed-1d4e-4196-aeeb-c69a05dc693b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("03609fd3-32a1-4aad-ba34-3f5b8ccbf7bc"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c7e9509d-1345-477d-ba3f-64fd5f22db64"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("27052b7c-585c-4423-bb92-8ae721fecf36"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("44dae368-bf84-4c59-a334-67214fdd54c5"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("47e5c39d-fe80-42e8-bc4a-2c5273c54784"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("5ec2aa7a-c2d6-4d11-8b63-702d635d2555"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("8223cb24-26b8-44e9-b5fc-3509a64af6bb"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("960c65a6-af65-4fd8-8251-ef8ae040fbd8"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("9e477352-e487-4148-b0be-195793d497d2"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("ae6b6c4e-9f96-4238-9e40-bf1a34d86d3f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b1539c49-9eb0-4ab5-9ad0-0ab2e6d92685"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("bbd81d4a-5042-4a26-9451-a44d099a35d3"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("be959c01-4b40-40e0-b969-c961d1193614"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("d0d37d81-906a-40cd-9bf6-ed141c92966d"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("d80f47d7-0f14-4360-b776-1362124c96ae"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("df043272-4df0-4bb1-9687-50adfdb9bba5"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("f0ca534e-4bf2-41f6-8720-a964f079f3cf"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("fac43fc2-c23b-481d-8a35-bd8af895b7ee"));

            migrationBuilder.InsertData(
                table: "ActivityTypes",
                columns: new[] { "Id", "ActivityName", "CreateDate", "DeleteDate", "EditDate" },
                values: new object[,]
                {
                    { new Guid("06e32f25-a796-41bf-a3e6-960729c2d5a2"), "Standard2", new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8570), null, null },
                    { new Guid("b109780a-988a-4186-b95e-a5916137f7eb"), "Standard1", new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8570), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("93f56303-eaec-4f81-8a0a-6f8ddbbde71e"), null, "Admin", "ADMIN" },
                    { new Guid("d00c788d-d745-4828-bf8c-b096c56553b0"), null, "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "EditDate", "VenueName" },
                values: new object[,]
                {
                    { new Guid("0ef8afde-ec4b-4577-8014-81731e486d53"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8520), null, null, "Venue13" },
                    { new Guid("213ed478-72fa-402d-86fc-cb124ca7f493"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8450), null, null, "Venue7" },
                    { new Guid("7438cbef-f0c0-43b2-bef1-a5c57b09d895"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8420), null, null, "Venue5" },
                    { new Guid("8ac0830f-bb35-4c82-a907-038b6f1af47f"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8510), null, null, "Venue12" },
                    { new Guid("8dbb6163-a4af-4085-bdc1-42e17b1074c5"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8400), null, null, "Venue3" },
                    { new Guid("91653fce-531c-4425-9cda-b5a8bc3f3b90"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8390), null, null, "Venue2" },
                    { new Guid("946bbaea-f379-4bf0-95a6-97be7c5aacd8"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8500), null, null, "Venue11" },
                    { new Guid("9a595615-00d8-422c-acda-a4da2d8588bb"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8320), null, null, "Venue1" },
                    { new Guid("a8de4114-0136-4f20-a86b-658c084d3c8f"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8440), null, null, "Venue6" },
                    { new Guid("b08534b6-5a5c-48a3-ac71-286712f32c93"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8460), null, null, "Venue8" },
                    { new Guid("b67f73a1-8416-488c-a21c-0f6bb5d694f8"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8480), null, null, "Venue10" },
                    { new Guid("d0ec3db0-90c6-4ef6-9681-6346135c329b"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8540), null, null, "Venue15" },
                    { new Guid("dfe5487d-a335-475b-9d40-b65f41d22129"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8470), null, null, "Venue9" },
                    { new Guid("e535ae14-01e1-4d5e-a29a-abcec3840881"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8550), null, null, "Venue16" },
                    { new Guid("e917b31a-3c53-48c4-994b-f1dc74f6ba58"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8410), null, null, "Venue4" },
                    { new Guid("e9d95cfe-d5ed-43b6-87d7-b2509f12b5ec"), new DateTime(2024, 7, 22, 15, 42, 39, 376, DateTimeKind.Local).AddTicks(8530), null, null, "Venue14" }
                });
        }
    }
}
