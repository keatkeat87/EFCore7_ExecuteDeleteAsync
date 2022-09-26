using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore7.Migrations
{
    /// <inheritdoc />
    public partial class adjust6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Addresses",
                table: "Customer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Addresses",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
