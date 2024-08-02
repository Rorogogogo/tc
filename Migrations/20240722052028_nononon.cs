using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class nononon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("3e93d98a-3cec-40cb-9543-7617583f2687"), "Standard2", new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5130), null, null },
                    { new Guid("acea5ae2-b041-4b4f-ac48-831bfa21e02b"), "Standard1", new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5120), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("c005ebd5-df26-4a92-a554-9289e2502840"), null, "Standard", "STANDARD" },
                    { new Guid("c063a82d-dbd0-444d-8788-40d9947ec298"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "EditDate", "VenueName" },
                values: new object[,]
                {
                    { new Guid("1181b9c3-785b-4bf8-aa7f-6fda7a720477"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5060), null, null, "Venue12" },
                    { new Guid("16ec356c-597c-468f-be89-5b098bd4b5c0"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(4850), null, null, "Venue1" },
                    { new Guid("2ca7f12f-a7a6-4c5f-b286-f45f5613eee3"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5020), null, null, "Venue9" },
                    { new Guid("554f9e5f-7688-4a85-a6a1-e6b4c5cc9a5b"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5050), null, null, "Venue11" },
                    { new Guid("5b387748-ce81-4962-a5c3-bf04ab659f2a"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5030), null, null, "Venue10" },
                    { new Guid("7950162e-9a8e-4e93-8d22-0d8c2d101bbe"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5000), null, null, "Venue7" },
                    { new Guid("7eec8ea5-bc1b-471a-a760-eb7474e12dba"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5100), null, null, "Venue15" },
                    { new Guid("81c48064-9047-419c-b025-066a4f5cfe02"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5010), null, null, "Venue8" },
                    { new Guid("8dfd26e2-be0d-43f3-9f70-276904635a10"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5080), null, null, "Venue14" },
                    { new Guid("92b146fe-481a-4442-9f6b-28b2dacaca97"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(4920), null, null, "Venue2" },
                    { new Guid("aeda736a-2903-440b-8b51-2bae8f956146"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(4970), null, null, "Venue6" },
                    { new Guid("b260bceb-185d-43a6-bd81-ef7835600231"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(4950), null, null, "Venue5" },
                    { new Guid("c6225c70-ae2d-453e-8e02-ec4521a9cefa"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(4940), null, null, "Venue4" },
                    { new Guid("d9c36141-1e7e-4ede-a13b-6f20e3b04396"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(4930), null, null, "Venue3" },
                    { new Guid("eaf31f7f-1a30-455a-b2e6-bf0c746ef696"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5070), null, null, "Venue13" },
                    { new Guid("fdfaaf4b-df48-4bda-9728-7537dba58230"), new DateTime(2024, 7, 22, 15, 20, 27, 986, DateTimeKind.Local).AddTicks(5110), null, null, "Venue16" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e93d98a-3cec-40cb-9543-7617583f2687"));

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("acea5ae2-b041-4b4f-ac48-831bfa21e02b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c005ebd5-df26-4a92-a554-9289e2502840"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c063a82d-dbd0-444d-8788-40d9947ec298"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("1181b9c3-785b-4bf8-aa7f-6fda7a720477"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("16ec356c-597c-468f-be89-5b098bd4b5c0"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("2ca7f12f-a7a6-4c5f-b286-f45f5613eee3"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("554f9e5f-7688-4a85-a6a1-e6b4c5cc9a5b"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("5b387748-ce81-4962-a5c3-bf04ab659f2a"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("7950162e-9a8e-4e93-8d22-0d8c2d101bbe"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("7eec8ea5-bc1b-471a-a760-eb7474e12dba"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("81c48064-9047-419c-b025-066a4f5cfe02"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("8dfd26e2-be0d-43f3-9f70-276904635a10"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("92b146fe-481a-4442-9f6b-28b2dacaca97"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("aeda736a-2903-440b-8b51-2bae8f956146"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("b260bceb-185d-43a6-bd81-ef7835600231"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("c6225c70-ae2d-453e-8e02-ec4521a9cefa"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("d9c36141-1e7e-4ede-a13b-6f20e3b04396"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("eaf31f7f-1a30-455a-b2e6-bf0c746ef696"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("fdfaaf4b-df48-4bda-9728-7537dba58230"));

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
    }
}
