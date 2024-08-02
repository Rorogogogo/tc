using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class nonon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "IdentityUser<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
    }
}
