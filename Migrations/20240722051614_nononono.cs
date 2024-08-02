using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class nononono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("068ae38b-4bfc-447b-b50d-af4cee9793a4"), "Standard1", new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4180), null, null },
                    { new Guid("c56945f7-9d8a-4c4f-8664-81f6611f8aa3"), "Standard2", new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4190), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("49986f51-dd36-41c0-a2b4-bcba1cfc32d0"), null, "Admin", "ADMIN" },
                    { new Guid("c76c1f63-df41-46bf-a6b8-c03e0b56d56f"), null, "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "EditDate", "VenueName" },
                values: new object[,]
                {
                    { new Guid("03deaffc-e12c-4956-a0df-e1713abe5e67"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4110), null, null, "Venue11" },
                    { new Guid("0bc231a8-166d-4cbf-b65f-b938530b6186"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4010), null, null, "Venue3" },
                    { new Guid("2472d3a3-0110-4139-a91c-a480757c7c12"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4130), null, null, "Venue13" },
                    { new Guid("2ba27b55-01b5-4ee6-a7f7-6545d681cf71"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4030), null, null, "Venue5" },
                    { new Guid("43a0e7a9-ac3b-4f9f-9c20-4095b823022c"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4160), null, null, "Venue15" },
                    { new Guid("4cf68c28-ecea-478b-9fed-bfe51ed0aebe"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4080), null, null, "Venue9" },
                    { new Guid("589f94de-b2b6-4dfc-b89c-4e202611bb1c"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4120), null, null, "Venue12" },
                    { new Guid("5cb9f866-c781-429a-be2f-58b3b4ee8ef3"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4070), null, null, "Venue8" },
                    { new Guid("64196746-8ac1-41ff-8f8e-d5f9ee961ac9"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(3910), null, null, "Venue1" },
                    { new Guid("6c760a3c-6cf2-4c3a-98ad-ee7fcb2686b7"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(3990), null, null, "Venue2" },
                    { new Guid("6f694de8-0e77-4b52-a26b-8525bc4231ca"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4060), null, null, "Venue7" },
                    { new Guid("92493bea-f322-406a-b05c-b1d9bf831be4"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4020), null, null, "Venue4" },
                    { new Guid("93b6c668-5bd4-43de-8469-a67cb8599587"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4140), null, null, "Venue14" },
                    { new Guid("b37a4438-ce8c-4329-aa21-c29c3ecc9449"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4170), null, null, "Venue16" },
                    { new Guid("b86b071a-83a2-4e15-be8a-fd54354e841e"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4050), null, null, "Venue6" },
                    { new Guid("f98c0422-0b23-4bc4-b394-0e601389be38"), new DateTime(2024, 7, 22, 15, 16, 14, 189, DateTimeKind.Local).AddTicks(4090), null, null, "Venue10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("068ae38b-4bfc-447b-b50d-af4cee9793a4"));

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("c56945f7-9d8a-4c4f-8664-81f6611f8aa3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("49986f51-dd36-41c0-a2b4-bcba1cfc32d0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c76c1f63-df41-46bf-a6b8-c03e0b56d56f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("03deaffc-e12c-4956-a0df-e1713abe5e67"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("0bc231a8-166d-4cbf-b65f-b938530b6186"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("2472d3a3-0110-4139-a91c-a480757c7c12"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("2ba27b55-01b5-4ee6-a7f7-6545d681cf71"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("43a0e7a9-ac3b-4f9f-9c20-4095b823022c"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("4cf68c28-ecea-478b-9fed-bfe51ed0aebe"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("589f94de-b2b6-4dfc-b89c-4e202611bb1c"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("5cb9f866-c781-429a-be2f-58b3b4ee8ef3"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("64196746-8ac1-41ff-8f8e-d5f9ee961ac9"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("6c760a3c-6cf2-4c3a-98ad-ee7fcb2686b7"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("6f694de8-0e77-4b52-a26b-8525bc4231ca"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("92493bea-f322-406a-b05c-b1d9bf831be4"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("93b6c668-5bd4-43de-8469-a67cb8599587"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b37a4438-ce8c-4329-aa21-c29c3ecc9449"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b86b071a-83a2-4e15-be8a-fd54354e841e"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("f98c0422-0b23-4bc4-b394-0e601389be38"));

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
    }
}
