using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tc.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "appointmentType",
                table: "Appointments",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "appointmentStatus",
                table: "Appointments",
                newName: "status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "type",
                table: "Appointments",
                newName: "appointmentType");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Appointments",
                newName: "appointmentStatus");
        }
    }
}
