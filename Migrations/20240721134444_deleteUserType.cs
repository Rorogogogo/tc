using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class deleteUserType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Venues",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "VenueActivitySetups",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "AspNetUsers",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Appointments",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "ActivityType",
                newName: "CreateDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Venues",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "VenueActivitySetups",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "AspNetUsers",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Appointments",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "ActivityType",
                newName: "CreatedDate");
        }
    }
}
