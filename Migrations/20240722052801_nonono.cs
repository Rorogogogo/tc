using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class nonono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "IdentityUser<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser<Guid>", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ActivityTypes",
                columns: new[] { "Id", "ActivityName", "CreateDate", "DeleteDate", "EditDate" },
                values: new object[,]
                {
                    { new Guid("03b5e89b-1764-4344-9349-b83cdd36abe1"), "Standard1", new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7870), null, null },
                    { new Guid("78daa19b-cc85-46f5-bfbf-0d1b66284894"), "Standard2", new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7870), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("072f2403-a36b-4447-b426-8b52f2f5687a"), null, "Admin", "ADMIN" },
                    { new Guid("85370869-4360-4991-8afc-b32b68cebc8b"), null, "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "EditDate", "VenueName" },
                values: new object[,]
                {
                    { new Guid("0960e4fa-2a36-4b58-a78c-f1bc1c66cf32"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7620), null, null, "Venue1" },
                    { new Guid("134ec962-bb04-4546-9fa8-77966ffca2da"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7710), null, null, "Venue4" },
                    { new Guid("1ee34391-d7e5-405d-a7a5-219321f60d1f"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7800), null, null, "Venue11" },
                    { new Guid("35794e73-94f4-4b69-92f3-8e434d34b00d"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7730), null, null, "Venue6" },
                    { new Guid("4031db9f-41b5-4c30-9df1-698406f56e40"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7690), null, null, "Venue3" },
                    { new Guid("53e2562f-6404-4904-85c9-dfdd6252aece"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7830), null, null, "Venue14" },
                    { new Guid("544d9edc-b466-424d-a03f-4bc0135e249b"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7770), null, null, "Venue9" },
                    { new Guid("5991f537-42aa-4618-8542-057a7d50eab4"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7780), null, null, "Venue10" },
                    { new Guid("5d7ed12b-9dbc-4a8b-9a92-cf24bb3f2e88"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7750), null, null, "Venue7" },
                    { new Guid("815c6494-bf27-40e7-82d4-046e12e9ddbd"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7680), null, null, "Venue2" },
                    { new Guid("87f4d30a-0b18-41d9-ae2b-e5a98f10ce30"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7760), null, null, "Venue8" },
                    { new Guid("91548182-355b-4190-8023-4fae056a1e7b"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7810), null, null, "Venue12" },
                    { new Guid("9a5bdafc-6778-4910-b9f6-29c53fdeebb5"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7720), null, null, "Venue5" },
                    { new Guid("9b34a4af-8511-4bb9-8edd-d6be424ba7c9"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7850), null, null, "Venue16" },
                    { new Guid("e004dc2e-4370-4528-8efa-8bb397754db8"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7820), null, null, "Venue13" },
                    { new Guid("fcc4e1f5-833b-4af6-8d1f-14b508bd3153"), new DateTime(2024, 7, 22, 15, 28, 1, 152, DateTimeKind.Local).AddTicks(7840), null, null, "Venue15" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_IdentityUser<Guid>_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "IdentityUser<Guid>",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_IdentityUser<Guid>_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "IdentityUser<Guid>");

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("03b5e89b-1764-4344-9349-b83cdd36abe1"));

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: new Guid("78daa19b-cc85-46f5-bfbf-0d1b66284894"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("072f2403-a36b-4447-b426-8b52f2f5687a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("85370869-4360-4991-8afc-b32b68cebc8b"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("0960e4fa-2a36-4b58-a78c-f1bc1c66cf32"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("134ec962-bb04-4546-9fa8-77966ffca2da"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("1ee34391-d7e5-405d-a7a5-219321f60d1f"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("35794e73-94f4-4b69-92f3-8e434d34b00d"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("4031db9f-41b5-4c30-9df1-698406f56e40"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("53e2562f-6404-4904-85c9-dfdd6252aece"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("544d9edc-b466-424d-a03f-4bc0135e249b"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("5991f537-42aa-4618-8542-057a7d50eab4"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("5d7ed12b-9dbc-4a8b-9a92-cf24bb3f2e88"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("815c6494-bf27-40e7-82d4-046e12e9ddbd"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("87f4d30a-0b18-41d9-ae2b-e5a98f10ce30"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("91548182-355b-4190-8023-4fae056a1e7b"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("9a5bdafc-6778-4910-b9f6-29c53fdeebb5"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("9b34a4af-8511-4bb9-8edd-d6be424ba7c9"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("e004dc2e-4370-4528-8efa-8bb397754db8"));

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: new Guid("fcc4e1f5-833b-4af6-8d1f-14b508bd3153"));

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
    }
}
