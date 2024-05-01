using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_EF.Migrations
{
    /// <inheritdoc />
    public partial class forigenkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_users_review_user_id",
                table: "users",
                column: "user_id",
                principalTable: "review",
                principalColumn: "review_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_review_user_id",
                table: "users");
        }
    }
}
