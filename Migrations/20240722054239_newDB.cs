using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class newDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("6e05dde7-fe64-4710-9b47-a5a9d7fee16c"));

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("e6b5edbb-8f65-41d0-961e-cd039bdc6541"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("15316ed5-7317-4454-9b66-e43d22b85105"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c74fcdbd-6450-465f-bb1a-936ec7478f88"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("1ecb4b81-d952-4a90-aa9e-eb76a178e3ea"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("2cc44bbe-74ec-4902-b323-edc295468d57"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("37635b26-3f87-48e8-a088-10f9188e6c24"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("4e2f316c-6bf8-4b0c-ac14-a2dd53e2c847"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("68d03fd7-810f-43cf-9273-f4ed2915924f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("7247da53-8a9f-49ff-99ad-58199fd276c7"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("7349ef47-30d9-495b-b96d-fb51226a48de"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("7ae8add4-7214-4501-a699-f17a9e31cac4"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("820fd01c-0335-4b87-a8e4-8ab239ea909a"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("897c9554-905f-483b-bff6-2ab8c16d6c00"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b0d6da51-20f6-4c48-99ef-df96ed6d642c"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b5d78833-2a3d-4ab3-a5cb-cf9bdc4cabc2"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("bd407f8b-cfed-4cb1-bbd1-831a4eeee5ac"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("c4f42dc1-61bc-4e5d-8fbe-4c29b61cb43a"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e320a7a1-c00c-4e76-9faf-87cf49074ac7"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("ec52d01b-56bb-4f76-ad56-e20c3e5f9b2a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("6e05dde7-fe64-4710-9b47-a5a9d7fee16c"), "Standard1", new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4610), null, null },
                    { new Guid("e6b5edbb-8f65-41d0-961e-cd039bdc6541"), "Standard2", new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4620), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("15316ed5-7317-4454-9b66-e43d22b85105"), null, "Admin", "ADMIN" },
                    { new Guid("c74fcdbd-6450-465f-bb1a-936ec7478f88"), null, "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "EditDate", "VenueName" },
                values: new object[,]
                {
                    { new Guid("1ecb4b81-d952-4a90-aa9e-eb76a178e3ea"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4350), null, null, "Venue1" },
                    { new Guid("2cc44bbe-74ec-4902-b323-edc295468d57"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4430), null, null, "Venue3" },
                    { new Guid("37635b26-3f87-48e8-a088-10f9188e6c24"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4490), null, null, "Venue7" },
                    { new Guid("4e2f316c-6bf8-4b0c-ac14-a2dd53e2c847"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4530), null, null, "Venue10" },
                    { new Guid("68d03fd7-810f-43cf-9273-f4ed2915924f"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4500), null, null, "Venue8" },
                    { new Guid("7247da53-8a9f-49ff-99ad-58199fd276c7"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4440), null, null, "Venue4" },
                    { new Guid("7349ef47-30d9-495b-b96d-fb51226a48de"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4550), null, null, "Venue12" },
                    { new Guid("7ae8add4-7214-4501-a699-f17a9e31cac4"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4580), null, null, "Venue14" },
                    { new Guid("820fd01c-0335-4b87-a8e4-8ab239ea909a"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4560), null, null, "Venue13" },
                    { new Guid("897c9554-905f-483b-bff6-2ab8c16d6c00"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4590), null, null, "Venue15" },
                    { new Guid("b0d6da51-20f6-4c48-99ef-df96ed6d642c"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4520), null, null, "Venue9" },
                    { new Guid("b5d78833-2a3d-4ab3-a5cb-cf9bdc4cabc2"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4410), null, null, "Venue2" },
                    { new Guid("bd407f8b-cfed-4cb1-bbd1-831a4eeee5ac"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4450), null, null, "Venue5" },
                    { new Guid("c4f42dc1-61bc-4e5d-8fbe-4c29b61cb43a"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4540), null, null, "Venue11" },
                    { new Guid("e320a7a1-c00c-4e76-9faf-87cf49074ac7"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4480), null, null, "Venue6" },
                    { new Guid("ec52d01b-56bb-4f76-ad56-e20c3e5f9b2a"), new DateTime(2024, 7, 22, 15, 31, 54, 736, DateTimeKind.Local).AddTicks(4600), null, null, "Venue16" }
                });
        }
    }
}
