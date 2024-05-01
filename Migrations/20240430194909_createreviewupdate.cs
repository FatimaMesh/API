using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_EF.Migrations
{
    /// <inheritdoc />
    public partial class createreviewupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "review",
                newName: "product_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "review",
                newName: "ProductId");
        }
    }
}
