using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForestersSiteCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddPageKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PageKey",
                table: "ContentPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageKey",
                table: "ContentPages");
        }
    }
}
