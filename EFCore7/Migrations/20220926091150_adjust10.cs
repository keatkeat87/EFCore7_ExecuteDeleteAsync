using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore7.Migrations
{
    /// <inheritdoc />
    public partial class adjust10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address_Line1",
                table: "Customer",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_Line2",
                table: "Customer",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_Line1",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Address_Line2",
                table: "Customer");
        }
    }
}
